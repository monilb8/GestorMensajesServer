using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorMensajesServer.Repository
{
    public interface IMensajeRepository
    {
        Mensaje Create(Mensaje Mensaje);
        Mensaje Get(long id);
        IQueryable<Mensaje> Get();
        void Put(Mensaje mensaje);
        Mensaje Delete(long id);
    }
}
