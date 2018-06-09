using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1.Classes
{
    public class Formulario
    {
        public string Carner { get; set; }
        public int IdCurso { get; set; }
        public int IdDep { get; set; }
        public int IdBeca { get; set; }
        public string Tel { get; set; }
        public  string Correo { get; set; }
        public double PromedioCurso { get; set; }
        public double PromedioPonderadoAnterior { get; set; }
        public double PromedioPonderadoGen { get; set; }
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