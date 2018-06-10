using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1.Classes
{
    public class RevisionSolicitud
    {

        // Solicitud

        public int IdSolicitud { get; set; }
        public string IdCarnet { get; set; }
        public int IdFormulario { get; set; }
        public int IdEstado { get; set; }
        public string Observacion { get; set; }
        public string FechaSolicitud { get; set; }
        public string PeriodoSolicitud { get; set; }

        // Formulario
        public string Carnet { get; set; }
        public int IdCurso { get; set; }
        public int IdForm { get; set; }
        public int IdDep { get; set; }
        public int IdBeca { get; set; }
        public string Tel { get; set; }
        public string Correo { get; set; }
        public decimal PromedioCurso { get; set; }
        public decimal PromedioPonderado { get; set; }
        public decimal PromedioPonderadoGen { get; set; }
        public int CuentaBancaria { get; set; }
        public string ImgCuentaBancaria { get; set; }
        public string ImgPromedioPonderado { get; set; }
        public string ImgPromedioPonderadoGeneral { get; set; }
        public string ImgCedula { get; set; }
        public string OtraBeca { get; set; }
        public int OtraBecaHoras { get; set; }
        public string Cedula { get; set; }

        // Estudiante

        public string carne { get; set; }
        public string correo_electronico { get; set; }
        public string primer_nombre { get; set; }
        public string segundo_nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }

    }
}