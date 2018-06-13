﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Proyecto1.Classes;

namespace Proyecto1.Services
{
    public class ReporteService
    {
        public List<Reporte> GetReporteInicialxTipoBeca(int anno, string beca, string periodo)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();

            SqlParameter Anno = new SqlParameter("@A", System.Data.SqlDbType.Int);
            Anno.Value = anno;

            SqlParameter TipoBeca = new SqlParameter("@TB", System.Data.SqlDbType.VarChar);
            TipoBeca.Value = beca;

            SqlParameter Periodo = new SqlParameter("@P", System.Data.SqlDbType.VarChar);
            Periodo.Value = periodo;
            List<Reporte> listReports = new List<Reporte>();
            command = new SqlCommand("EXEC ReporteInicialxTipoBeca @Anno=@A, @Periodo = @P,@TipoBeca = @TB ", conn);
            command.Parameters.Add(Anno);
            command.Parameters.Add(TipoBeca);
            command.Parameters.Add(Periodo);

            read = command.ExecuteReader();
            while (read.Read())
            {

                Reporte reporte = new Reporte();
                reporte.PrimerNombre = read["primer_nombre"].ToString();
                reporte.PrimerNombre = read["segundo_nombre"].ToString();
                reporte.PrimerApellido = read["primer_apellido"].ToString();
                reporte.PrimerApellido = read["segundo_apellido"].ToString();
                reporte.PromedioPonderado = Convert.ToInt32(read["PromedioPonderadoGeneral"]);
                reporte.HorasAsignadas = Convert.ToInt32(read["HorasSolicitadas"]);
                listReports.Add(reporte);

            }
            read.Close();
            conn.Close();

            return listReports;
        }

        public List<Reporte> GetReporteInicialGeneral(int anno, string periodo)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();

            SqlParameter Anno = new SqlParameter("@A", System.Data.SqlDbType.Int);
            Anno.Value = anno;
            SqlParameter Periodo = new SqlParameter("@P", System.Data.SqlDbType.VarChar);
            Periodo.Value = periodo;
            List<Reporte> listReports = new List<Reporte>();
            command = new SqlCommand("EXEC ReporteInicialGeneral @Anno=@A, @Periodo = @P", conn);
            command.Parameters.Add(Anno);
          
            command.Parameters.Add(Periodo);

            read = command.ExecuteReader();
            while (read.Read())
            {

                Reporte reporte = new Reporte();
                reporte.PrimerNombre = read["primer_nombre"].ToString();
                reporte.PrimerNombre = read["segundo_nombre"].ToString();
                reporte.PrimerApellido = read["primer_apellido"].ToString();
                reporte.PrimerApellido = read["segundo_apellido"].ToString();
                reporte.PromedioPonderado = Convert.ToInt32(read["PromedioPonderadoGeneral"]);
                reporte.HorasAsignadas = Convert.ToInt32(read["HorasSolicitadas"]);
                listReports.Add(reporte);

            }
            read.Close();
            conn.Close();

            return listReports;
        }

        public List<Reporte> GetReporteFinalxTipoBeca(int anno, string beca, string periodo)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();

            SqlParameter Anno = new SqlParameter("@A", System.Data.SqlDbType.Int);
            Anno.Value = anno;

            SqlParameter TipoBeca = new SqlParameter("@TB", System.Data.SqlDbType.VarChar);
            TipoBeca.Value = beca;

            SqlParameter Periodo = new SqlParameter("@P", System.Data.SqlDbType.VarChar);
            Periodo.Value = periodo;
            List<Reporte> listReports = new List<Reporte>();
            command = new SqlCommand("EXEC ReporteFinalxTipoBeca @Anno=@A, @Periodo = @P,@TipoBeca = @TB ", conn);
            command.Parameters.Add(Anno);
            command.Parameters.Add(TipoBeca);
            command.Parameters.Add(Periodo);

            read = command.ExecuteReader();
            while (read.Read())
            {

                Reporte reporte = new Reporte();
                reporte.PrimerNombre = read["primer_nombre"].ToString();
                reporte.PrimerNombre = read["segundo_nombre"].ToString();
                reporte.PrimerApellido = read["primer_apellido"].ToString();
                reporte.PrimerApellido = read["segundo_apellido"].ToString();
                reporte.PromedioPonderado = Convert.ToInt32(read["PromedioPonderadoGeneral"]);
                reporte.HorasAsignadas = Convert.ToInt32(read["HorasAsignadas"]);
                reporte.HorasLaboradas = Convert.ToInt32(read["HorasLaboradas"]);

                listReports.Add(reporte);

            }
            read.Close();
            conn.Close();

            return listReports;
        }

        public List<Reporte> GetReporteFinalGeneral(int anno, string periodo)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();

            SqlParameter Anno = new SqlParameter("@A", System.Data.SqlDbType.Int);
            Anno.Value = anno;


            SqlParameter Periodo = new SqlParameter("@P", System.Data.SqlDbType.VarChar);
            Periodo.Value = periodo;
            List<Reporte> listReports = new List<Reporte>();
            command = new SqlCommand("EXEC ReporteInicialGeneral @Anno=@A, @Periodo = @P", conn);
            command.Parameters.Add(Anno);
     
            command.Parameters.Add(Periodo);

            read = command.ExecuteReader();
            while (read.Read())
            {

                Reporte reporte = new Reporte();
                reporte.PrimerNombre = read["primer_nombre"].ToString();
                reporte.PrimerNombre = read["segundo_nombre"].ToString();
                reporte.PrimerApellido = read["primer_apellido"].ToString();
                reporte.PrimerApellido = read["segundo_apellido"].ToString();
                reporte.PromedioPonderado = Convert.ToInt32(read["PromedioPonderadoGeneral"]);
                reporte.HorasAsignadas = Convert.ToInt32(read["HorasAsignadas"]);
                reporte.HorasLaboradas = Convert.ToInt32(read["HorasLaboradas"]);

                listReports.Add(reporte);

            }
            read.Close();
            conn.Close();

            return listReports;
        }
    }
}