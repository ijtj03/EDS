using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Classes;
using System.Web.Http;
using System.Data.SqlClient;

namespace Proyecto1.Services
{
    public class VariosService
    {
        public List<Departamento> GetAllDeps()
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            List<Departamento> ListForms = new List<Departamento>();

            command = new SqlCommand("Select * from Departamento where IdDepartamento!=1 and [Delete] = 0", conn);
            read = command.ExecuteReader();
            while (read.Read())
            {
                Departamento persona = new Departamento();
                persona.IdDep = Convert.ToInt32(read["IdDepartamento"]);
                persona.Nombre = read["Nombre"].ToString();
                ListForms.Add(persona);

            }
            read.Close();


            conn.Close();
            return ListForms;
        }
        public List<Departamento> GetAllCursos()
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            List<Departamento> ListForms = new List<Departamento>();

            command = new SqlCommand("Select * from Curso where IdCurso!=1 and [Delete] = 0", conn);
            read = command.ExecuteReader();
            while (read.Read())
            {
                Departamento persona = new Departamento();
                persona.IdDep = Convert.ToInt32(read["IdCurso"]);
                persona.Nombre = read["Codigo"].ToString();
                ListForms.Add(persona);

            }
            read.Close();


            conn.Close();
            return ListForms;
        }

        public List<Departamento> GetRoles()
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            List<Departamento> ListForms = new List<Departamento>();

            command = new SqlCommand("select * from rol where sistema != 1 ", conn);
            read = command.ExecuteReader();
            while (read.Read())
            {
                Departamento persona = new Departamento();
                persona.IdDep = Convert.ToInt32(read["id_rol"]);
                persona.Nombre = read["Nombre"].ToString();
                ListForms.Add(persona);

            }
            read.Close();


            conn.Close();
            return ListForms;
        }
    }
}