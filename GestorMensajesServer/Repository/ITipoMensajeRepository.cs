using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorMensajesServer.Repository
{
    public interface ITipoMensajeRepository
    {
        TipoMensaje Create(TipoMensaje usuario);
        TipoMensaje Get(long id);
        IQueryable<TipoMensaje> Get();
        void Put(TipoMensaje usuario);
        TipoMensaje Delete(long id);
    }
}
