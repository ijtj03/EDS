using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1.Classes
{
    public class Solicitud
    {
        public int IdSolicitud { get; set; }
        public string IdCarnet { get; set; }
        public int IdFormulario { get; set; }
        public int IdEstado { get; set; }
        public string Observacion { get; set; }
        public string FechaSolicitud { get; set; }
        public string PeriodoSolicitud { get; set; }
        public int IdTipoBeca { get; set; }
        public string NombreBeca { get; set; }


    }
}