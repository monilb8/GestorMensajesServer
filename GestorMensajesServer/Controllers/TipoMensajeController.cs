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
        private ITipoMensajeService TipoMensajeService;

        public MensajeController(ITipoMensajeService _TipoMensajeService)
        {
            this.TipoMensajeService = _TipoMensajeService;
        }

        // GET: api/TipoMensaje
        public IQueryable<TipoMensaje> GetTipoMensaje()
        {
            return TipoMensajeService.Get();
        }

        // GET: api/TipoMensaje/5
        [ResponseType(typeof(TipoMensaje))]
        public IHttpActionResult GetTipoMensaje(long id)
        {
            TipoMensaje TipoMensaje = TipoMensajeService.Get(id);
            if (TipoMensaje == null)
            {
                return NotFound();
            }

            return Ok(TipoMensaje);
        }

        // PUT: api/TipoMensaje/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipoMensaje(long id, TipoMensaje TipoMensaje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != TipoMensaje.Id)
            {
                return BadRequest();
            }

            try
            {
                TipoMensajeService.Put(TipoMensaje);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/TipoMensaje
        [ResponseType(typeof(TipoMensaje))]
        public IHttpActionResult PostUsuario(TipoMensaje TipoMensaje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TipoMensaje = TipoMensajeService.Create(TipoMensaje);

            return CreatedAtRoute("DefaultApi", new { id = TipoMensaje.Id }, TipoMensaje);
        }

        // DELETE: api/TipoMensaje/5
        [ResponseType(typeof(TipoMensaje))]
        public IHttpActionResult DeleteTipoMensaje(long id)
        {
            TipoMensaje TipoMensaje;
            try
            {
                TipoMensaje = TipoMensajeService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(TipoMensaje);
        }
    }
}