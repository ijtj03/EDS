using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1.Classes
{
    public class Parametro
    {
        public int IdParametro { get; set; }
        public string FechaAjuste { get; set; }
        public string FechaInicialSol { get; set; }
        public string FechaFinalSol { get; set; }
        public string FechaInicialCal { get; set; }
        public string FechaFinalCal { get; set; }
        public int HorasBecaTotales { get; set; }
        public int HorasBecaEstudiante { get; set; }
        public int HorasBecaAsis { get; set; }
        public int HorasBecaAsEsp { get; set; }
        public int HorasBecaTutoria { get; set; }
    }
}