using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1.Classes
{
    public class Formulario
    {
        public string Carnet { get; set; }
        public int IdCurso { get; set; }
        public int IdForm { get; set; }
        public int IdDep { get; set; }
        public int IdBeca { get; set; }
        public string Tel { get; set; }
        public string Correo { get; set; }
        public decimal PromedioCurso { get; set; }
        public decimal PromedioPonderadoAnterior { get; set; }
        public decimal PromedioPonderadoGen { get; set; }
        public int CuentaBancaria { get; set; }
        public string ImgCuentaBancaria { get; set; }
        public string ImgPromedioPonderadoAnterios { get; set; }
        public string ImgPromedioPonderadoGeneral { get; set; }
        public string ImgCedula { get; set; }
        public string OtraBeca { get; set; }
        public int OtraBecaHoras { get; set; }
        public string Cedula { get; set; }
    }
}