using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Classes;
using System.Web.Http;
using System.Data.SqlClient;


namespace Proyecto1.Services
{
    public class EstudianteService
    {
       
        public List<Estudiante> GetAllEstudiantes()
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            List<Estudiante> ListEstudiante = new List<Estudiante>();

            command = new SqlCommand("SELECT *  from estudiantes where [Delete] = 0", conn);
            read = command.ExecuteReader();
            while (read.Read())
            {
                Estudiante es = new Estudiante();
                es.carne = read["carne"].ToString();
                es.correo_electronico = read["correo_electronico"].ToString();
                es.primer_apellido = read["primer_apellido"].ToString();
                es.primer_nombre = read["primer_nombre"].ToString();
                es.segundo_apellido = read["segundo_apellido"].ToString();
                es.segundo_nombre = read["segundo_nombre"].ToString();


                ListEstudiante.Add(es);

            }
            read.Close();


            conn.Close();
            return ListEstudiante;
        }
   
    }
}