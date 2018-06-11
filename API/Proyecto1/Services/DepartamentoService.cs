using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Classes;
using System.Web.Http;
using System.Data.SqlClient;

namespace Proyecto1.Services
{
    public class DepartamentoService
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

            command = new SqlCommand("Select * from Departamento where [Delete] = 0", conn);
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
    }
}