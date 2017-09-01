using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorMensajesServer.Servicios
{
    public interface IMensajeService
    {
        Mensaje Create(Mensaje Mensaje);
        Mensaje Get(long id);
        IQueryable<Mensaje> Get();
        void Put(Mensaje Mensaje);
        Mensaje Delete(long id);
    }
}
