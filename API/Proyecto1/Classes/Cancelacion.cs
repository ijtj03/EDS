using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1.Classes
{
    public class Cancelacion
    {
        public string IdCarnet { get; set; }
        public string Observacion { get; set; }
        public string TBNombre { get; set; } // Nombre Tipo de Beca
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int IdSolicitud { get; set; }

    }
}