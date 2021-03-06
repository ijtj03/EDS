﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Classes;
using System.Web.Http;
using System.Data.SqlClient;

namespace Proyecto1.Services
{
    public class EvaluarService
    {
        public List<Evaluacion> GetEstudiantesxUsuario(int encargado)
        {
        
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            List<Evaluacion> listForms = new List<Evaluacion>();
       

            SqlParameter usuario = new SqlParameter("@U", System.Data.SqlDbType.Int);
            usuario.Value = encargado;

            command = new SqlCommand("EXEC ObtenerEstudiantesxEvaluar @IdUsuario=@U", conn);
           
            command.Parameters.Add(usuario);
     
            read = command.ExecuteReader();
            while (read.Read())
            {
               
                Evaluacion informacion = new Evaluacion();
                informacion.Carnet = read["carne"].ToString();
                informacion.IdEvaluacion = Convert.ToInt32(read["IdEvaluacion"]);
                informacion.Observaciones = read["Observaciones"].ToString();
                informacion.PrimerNombre = read["primer_nombre"].ToString();
                informacion.SegundoNombre = read["segundo_nombre"].ToString();
                informacion.PrimerApellido = read["primer_apellido"].ToString();
                informacion.SegundoApellido = read["segundo_apellido"].ToString();
                informacion.HorasAsignadas = Convert.ToInt32(read["HorasAsignadas"]);
                informacion.TipoBeca = read["Nombre"].ToString();
                if (informacion.Observaciones=="") { informacion.Revisado = false;
                    informacion.SegundoNombre = "No Revisado";
                } else { informacion.Revisado = true;
                    informacion.SegundoNombre ="Revisado";
                }
                listForms.Add(informacion);

            }
            read.Close();
            conn.Close();
            return listForms;
        }
        public void GuardarEvaluacion([FromBody] Evaluacion evaluacion)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;

            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();

            SqlParameter idEvaluacion = new SqlParameter("@IE", System.Data.SqlDbType.Int);
            idEvaluacion.Value = evaluacion.IdEvaluacion;

            SqlParameter recomienda = new SqlParameter("@R", System.Data.SqlDbType.Int);
            recomienda.Value = evaluacion.Recomienda;

            SqlParameter horasLaboradas = new SqlParameter("@HL", System.Data.SqlDbType.Int);
            horasLaboradas.Value = evaluacion.HorasLaboradas;

            SqlParameter observaciones = new SqlParameter("@O", System.Data.SqlDbType.VarChar);
            observaciones.Value = evaluacion.Observaciones;

            command = new SqlCommand("EXEC EvaluarEstudiantes @IdEvaluacion = @IE,@Recomienda = @R,@HorasLaboradas = @HL,@Observaciones = @O  ", conn);
            command.Parameters.Add(idEvaluacion);
            command.Parameters.Add(recomienda);
            command.Parameters.Add(horasLaboradas);
            command.Parameters.Add(observaciones);

            command.ExecuteNonQuery();


            conn.Close();
        }
        public List<Evaluacion> GetAllEvaluaciones()
        {
            
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            List<Evaluacion> listForms = new List<Evaluacion>();
            command = new SqlCommand("SELECT * FROM Evaluacion", conn);
            read = command.ExecuteReader();
            while (read.Read())
            {

                Evaluacion informacion = new Evaluacion();
                informacion.IdEvaluacion = Convert.ToInt32(read["IdEvaluacion"]);
                informacion.HorasAsignadas = Convert.ToInt32(read["HorasAsignadas"]);
                listForms.Add(informacion);

            }
            read.Close();
            conn.Close();
            return listForms;
        }

    }
}