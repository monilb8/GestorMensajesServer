using GestorMensajesServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorMensajesServer.Servicios
{
    public class TipoMensajeService : ITipoMensajeService
    {
        private ITipoMensajeRepository TipoMensajeRepository;
        public TipoMensajeService(ITipoMensajeRepository _TipoMensajeRepository)
        {
            this.TipoMensajeRepository = _TipoMensajeRepository;
        }

        public TipoMensaje Get(long id)
        {
            return TipoMensajeRepository.Get(id);
        }

        public IQueryable<TipoMensaje> Get()
        {
            return TipoMensajeRepository.Get();
        }

        public TipoMensaje Create(TipoMensaje TipoMensaje)
        {
            return TipoMensajeRepository.Create(TipoMensaje);
        }

        public void Put(TipoMensaje TipoMensaje)
        {
            TipoMensajeRepository.Put(TipoMensaje);
        }

        public TipoMensaje Delete(long id)
        {
            return TipoMensajeRepository.Delete(id);
        }
    }
}