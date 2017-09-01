using GestorMensajesServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GestorMensajesServer.Repository
{
    public class TipoMensajeRepository : ITipoMensajeRepository
    {
        public TipoMensaje Create(TipoMensaje TipoMensaje)
        {
            return ApplicationDbContext.applicationDbContext.TipoMensaje.Add(TipoMensaje);
        }

        public TipoMensaje Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.TipoMensaje.Find(id);
        }

        public IQueryable<TipoMensaje> Get()
        {
            IList<TipoMensaje> lista = new List<TipoMensaje>(ApplicationDbContext.applicationDbContext.TipoMensaje);

            return lista.AsQueryable();
        }


        public void Put(TipoMensaje TipoMensaje)
        {
            if (ApplicationDbContext.applicationDbContext.TipoMensaje.Count(e => e.Id == TipoMensaje.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(TipoMensaje).State = EntityState.Modified;
        }

        public TipoMensaje Delete(long id)
        {
            TipoMensaje TipoMensaje = ApplicationDbContext.applicationDbContext.TipoMensaje.Find(id);
            if (TipoMensaje == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.TipoMensaje.Remove(TipoMensaje);
            return TipoMensaje;
        }
    }
}