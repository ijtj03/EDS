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