using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1.Classes
{
    public class Reporte
    {
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Carne { get; set; }
        public int PromedioPonderado { get; set; }
        public string TipoBeca { get; set; }
        public int HorasAsignadas { get; set; }
        public int HorasLaboradas { get; set; }
        public string Observaciones { get; set; }
    }
}