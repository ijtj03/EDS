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
        public List<UsuarioxEstudiante> GetEstudiantesxUsuario(int encargado)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            List<UsuarioxEstudiante> ListForms = new List<UsuarioxEstudiante>();

            command = new SqlCommand("Select E.carne,E.primer_nombre,E.primer_apellido,UE.HorasAsignadas,UE.HorasLaboradas,UE.Observaciones from usuario as U inner join UsuarioxEstudiante as UE on U.id = UE.IdUsuario inner join estudiantes as E on E.carne=UE.IdCarnet where UE.[Delete] = 0 and U.id="+encargado.ToString(), conn);
            read = command.ExecuteReader();
            while (read.Read())
            {
                UsuarioxEstudiante persona = new UsuarioxEstudiante();
                persona.HorasAsignadas = Convert.ToInt32(read["HorasAsignadas"]);
                persona.HorasLaboradas = Convert.ToInt32(read["HorasLaboradas"]);
                persona.Carnet = read["carne"].ToString();
                persona.Nombre = read["primer_nombre"].ToString();
                persona.Apellido = read["primer_apellido"].ToString();
                persona.Observaciones = read["Observaciones"].ToString();
                if (persona.Observaciones=="") { persona.Revisado = false; }
                else { persona.Revisado = true; }
                ListForms.Add(persona);

            }
            read.Close();


            conn.Close();
            return ListForms;
        }
    }
}