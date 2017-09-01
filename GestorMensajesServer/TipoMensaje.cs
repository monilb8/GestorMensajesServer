using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorMensajesServer
{
    public class TipoMensaje
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public bool Fichero { get; set; }
        public bool Destacado { get; set; }
        public string Base { get; set; }
    }
}