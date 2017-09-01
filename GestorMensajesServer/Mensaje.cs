using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorMensajesServer
{
    public class Mensaje
    {
        public long Id { get; set; }
        public string Cabecera { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }
        public string Archivo { get; set; }
        public DateTime Fecha { get; set; }
        public bool Destacado { get; set; }
    }
}