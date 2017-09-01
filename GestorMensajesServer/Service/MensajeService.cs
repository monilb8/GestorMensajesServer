using GestorMensajesServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorMensajesServer.Servicios
{
    public class MensajeService: IMensajeService
    {
        private IMensajeRepository mensajeReposistory;
        public MensajeService(IMensajeRepository _MensajeRepository)
        {
            this.mensajeReposistory = _MensajeRepository;
        }

        public Mensaje Get(long id)
        {
            return mensajeReposistory.Get(id);
        }

        public IQueryable<Mensaje> Get()
        {
            return mensajeReposistory.Get();
        }

        public Mensaje Create(Mensaje Mensaje)
        {
            return mensajeReposistory.Create(Mensaje);
        }

        public void Put(Mensaje Mensaje)
        {
            mensajeReposistory.Put(Mensaje);
        }

        public Mensaje Delete(long id)
        {
            return mensajeReposistory.Delete(id);
        }
    }
}