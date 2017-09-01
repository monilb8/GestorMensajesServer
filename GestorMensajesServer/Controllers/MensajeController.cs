using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GestorMensajesServer;
using GestorMensajesServer.Models;
using GestorMensajesServer.Servicios;
using System.Web.Http.Cors;

namespace GestorMensajesServer.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]

    public class MensajeController : ApiController
    {
        private IMensajeService mensajeService;

        public MensajeController(IMensajeService _mensajeService)
        {
            this.mensajeService = _mensajeService;
        }

        // GET: api/Mensaje
        public IQueryable<Mensaje> GetMensaje()
        {
            return mensajeService.Get();
        }

        // GET: api/Mensaje/5
        [ResponseType(typeof(Mensaje))]
        public IHttpActionResult GetMensaje(long id)
        {
            Mensaje mensaje = mensajeService.Get(id);
            if (mensaje == null)
            {
                return NotFound();
            }

            return Ok(mensaje);
        }

        // PUT: api/Mensaje/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMensaje(long id, Mensaje mensaje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mensaje.Id)
            {
                return BadRequest();
            }

            try
            {
                mensajeService.Put(mensaje);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Mensaje
        [ResponseType(typeof(Mensaje))]
        public IHttpActionResult PostMensaje(Mensaje mensaje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            mensaje = mensajeService.Create(mensaje);

            return CreatedAtRoute("DefaultApi", new { id = mensaje.Id }, mensaje);
        }

        // DELETE: api/Mensaje/5
        [ResponseType(typeof(Mensaje))]
        public IHttpActionResult DeleteMensaje(long id)
        {
            Mensaje pelicula;
            try
            {
                pelicula = mensajeService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(pelicula);
        }
    }
}