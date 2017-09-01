using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorMensajesServer.Servicios
{
    public interface ITipoMensajeService
    {
        TipoMensaje Create(TipoMensaje TipoMensaje);
        TipoMensaje Get(long id);
        IQueryable<TipoMensaje> Get();
        void Put(TipoMensaje TipoMensaje);
        TipoMensaje Delete(long id);
    }
}
