using GestorMensajesServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GestorMensajesServer.Repository
{
    public class MensajeRepository : IMensajeRepository
    {
        public Mensaje Create(Mensaje Mensaje)
        {
            return ApplicationDbContext.applicationDbContext.Mensaje.Add(Mensaje);
        }

        public Mensaje Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.Mensaje.Find(id);
        }

        public IQueryable<Mensaje> Get()
        {
            IList<Mensaje> lista = new List<Mensaje>(ApplicationDbContext.applicationDbContext.Mensaje);

            return lista.AsQueryable();
        }


        public void Put(Mensaje Mensaje)
        {
            if (ApplicationDbContext.applicationDbContext.Mensaje.Count(e => e.Id == Mensaje.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(Mensaje).State = EntityState.Modified;
        }

        public Mensaje Delete(long id)
        {
            Mensaje Mensaje = ApplicationDbContext.applicationDbContext.Mensaje.Find(id);
            if (Mensaje == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.Mensaje.Remove(Mensaje);
            return Mensaje;
        }
    }
}