using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Classes;
using System.Web.Http;
using System.Data.SqlClient;

namespace Proyecto1.Services
{
    public class CalificarService
    {
        public List<Estudiante> GetEstudiantesxUsuario(int encargado)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            List<Estudiante> ListForms = new List<Estudiante>();

            /*command = new SqlCommand("SELECT *  from Formulario where [Delete] = 0", conn);
            read = command.ExecuteReader();
            while (read.Read())
            {
                Formulario persona = new Formulario();
                persona.IdCurso = Convert.ToInt32(read["IdCurso"]);
                persona.IdForm = Convert.ToInt32(read["IdFormulario"]);
                persona.IdDep = Convert.ToInt32(read["IdDepartamento"]);
                persona.IdBeca = Convert.ToInt32(read["IdTipoBeca"]);
                persona.Tel = read["Telefono"].ToString();
                persona.Correo = read["Correo"].ToString();
                persona.PromedioCurso = Convert.ToDecimal(read["IdTipoBeca"]);
                persona.PromedioPonderadoAnterior = Convert.ToDecimal(read["PromedioPonderadoAnterior"]);
                persona.PromedioPonderadoGen = Convert.ToDecimal(read["PromedioPonderadoGeneral"]);
                persona.CuentaBancaria = Convert.ToInt32(read["CuentaBancaria"]);
                persona.ImgCuentaBancaria = read["ImgCuentaBancaria"].ToString();
                persona.ImgPromedioPonderadoAnterios = read["ImgPromedioPonderado"].ToString();
                persona.ImgPromedioPonderadoGeneral = read["ImgPromedioGeneral"].ToString();
                persona.ImgCedula = read["ImgCedula"].ToString();
                persona.OtraBeca = read["OtraBeca"].ToString();
                persona.OtraBecaHoras = Convert.ToInt32(read["OtraBecaHoras"]);
                persona.Cedula = read["Cedula"].ToString();

                ListForms.Add(persona);

            }
            read.Close();


            conn.Close();*/
            return ListForms;
        }
    }
}