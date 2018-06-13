using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Proyecto1.Classes;

namespace Proyecto1.Services
{
    public class ParametroService
    {
        public Parametro GetLast()
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlCommand command2;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            command = new SqlCommand("SELECT MAX(IdParametro) FROM Parametro where [Delete]=0", conn);
            int r = -1;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                r = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            command2 = new SqlCommand("SELECT * FROM Parametro WHERE IdParametro="+r.ToString(), conn);
            read = command2.ExecuteReader();
            List<Parametro> ListForms = new List<Parametro>();
            Parametro persona = new Parametro();
            while (read.Read())
            {
                persona.IdParametro = Convert.ToInt32(read["IdParametro"]);
                persona.HorasBecaTutoria = Convert.ToInt32(read["HorasBecaTutoria"]);
                persona.HorasBecaTotales = Convert.ToInt32(read["HorasBecaTotales"]);
                persona.HorasBecaEstudiante= Convert.ToInt32(read["HorasBecaEstudiante"]);
                persona.HorasBecaAsis= Convert.ToInt32(read["HorasBecaAsis"]);
                persona.HorasBecaAsEsp = Convert.ToInt32(read["HorasBecaAsEsp"]);
                persona.FechaAjuste = Convert.ToString(read["HorasBecaAsEsp"]);
                persona.FechaFinalCal = read["FechaFinalCal"].ToString();
                persona.FechaFinalSol = Convert.ToString(read["FechaFinalSol"]);
                persona.FechaInicialCal = read["FechaInicialCal"].ToString();
                persona.FechaInicialSol = Convert.ToString(read["FechaInicialSol"]);

            }
            read.Close();
            return persona; 

        }

        public int GuardarParametros(Parametro param)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            command = new SqlCommand("EXEC GuardarParametros @FechaAjuste=@FA,@FechaInicialSol=@FIS," +
                "@FechaFinalSol=@FFS,@FechaInicialCal=@FIC,@FechaFinalCal=@FFC,@HorasBecaTotales=@HBT,@HorasBecaEstudiante=@HBE," +
                "@HorasBecaAsis=@HBA,@HorasBecaAsEsp=@HBAE,@HorasBecaTutoria=@HBTu", conn);
            
            command.Parameters.AddWithValue("@FA", param.FechaAjuste);
            command.Parameters.AddWithValue("@FIS", param.FechaInicialSol);
            command.Parameters.AddWithValue("@FFS", param.FechaFinalSol);
            command.Parameters.AddWithValue("@FIC", param.FechaInicialCal);
            command.Parameters.AddWithValue("@FFC", param.FechaFinalCal);
            command.Parameters.AddWithValue("@HBAE", param.HorasBecaAsEsp);
            command.Parameters.AddWithValue("@HBA", param.HorasBecaAsis);
            command.Parameters.AddWithValue("@HBT", param.HorasBecaTotales);
            command.Parameters.AddWithValue("@HBTu", param.HorasBecaTutoria);
            command.Parameters.AddWithValue("@HBE", param.HorasBecaEstudiante);
            int r = command.ExecuteNonQuery();

            conn.Close();
            return r;
        }
        public int ActualizarParametros(Parametro param)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            command = new SqlCommand("EXEC ActualizarParametros @IdParametro=@IP,@FechaAjuste=@FA,@FechaInicialSol=@FIS," +
                "@FechaFinalSol=@FFS,@FechaInicialCal=@FIC,@FechaFinalCal=@FFC,@HorasBecaTotales=@HBT,@HorasBecaEstudiante=@HBE," +
                "@HorasBecaAsis=@HBA,@HorasBecaAsEsp=@HBAE,@HorasBecaTutoria=@HBTu", conn);

            command.Parameters.AddWithValue("@IP", param.IdParametro);
            command.Parameters.AddWithValue("@FA", param.FechaAjuste);
            command.Parameters.AddWithValue("@FIS", param.FechaInicialSol);
            command.Parameters.AddWithValue("@FFS", param.FechaFinalSol);
            command.Parameters.AddWithValue("@FIC", param.FechaInicialCal);
            command.Parameters.AddWithValue("@FFC", param.FechaFinalCal);
            command.Parameters.AddWithValue("@HBAE", param.HorasBecaAsEsp);
            command.Parameters.AddWithValue("@HBA", param.HorasBecaAsis);
            command.Parameters.AddWithValue("@HBT", param.HorasBecaTotales);
            command.Parameters.AddWithValue("@HBTu", param.HorasBecaTutoria);
            command.Parameters.AddWithValue("@HBE", param.HorasBecaEstudiante);
            int r = command.ExecuteNonQuery();

            conn.Close();
            return r;
        }
    }
}