using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Classes;
using System.Web.Http;
using System.Data.SqlClient;


namespace Proyecto1.Services
{
    public class SolicitudService
    {
        
        
        public List<Solicitud> GetAllSolicitudes()
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            List<Solicitud> ListSolicitud = new List<Solicitud>();

            command = new SqlCommand("SELECT *  from Solicitud where [Delete] = 0", conn);
            read = command.ExecuteReader();
            while (read.Read())
            {
                Solicitud sol = new Solicitud();
                sol.IdCarnet = read["IdCarnet"].ToString();
                sol.IdSolicitud = Convert.ToInt32(read["IdSolicitud"]);
                sol.IdFormulario = Convert.ToInt32(read["IdFormulario"]);
                sol.IdEstado = Convert.ToInt32(read["IdEstado"]);
                sol.Observacion = read["Observacion"].ToString();
                sol.PeriodoSolicitud = read["PeriodoSolicitud"].ToString();
                sol.FechaSolicitud = read["FechaSolicitud"].ToString();

                ListSolicitud.Add(sol);

            }
            read.Close();


            conn.Close();
            return ListSolicitud;
        }

        public List<RevisionSolicitud> GetSolicitudesRevision (int TipoBeca)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            List<RevisionSolicitud> ListRS = new List<RevisionSolicitud>();

            command = new SqlCommand("select * from Solicitud as S inner join EstadoSolicitud as ES on S.IdEstado = ES.IdEstado inner join estudiantes as E on E.carne = S.IdCarnet inner join EstudiantexFormulario as EF on EF.IdCarnet = E.carne inner join Formulario as F on EF.IdFormulario = F.IdFormulario inner join TipoBeca as TB on TB.IdTipoBeca = F.IdTipoBeca where S.[Delete] = 0 and  TB.IdTipoBeca =" + TipoBeca.ToString(), conn);
            read = command.ExecuteReader();
            while (read.Read())
            {
                RevisionSolicitud rs = new RevisionSolicitud();

                rs.carne = read["carne"].ToString();
                //rs.Carnet = read["Carnet"].ToString();
                rs.Cedula = read["Cedula"].ToString();
                rs.Correo = read["Correo"].ToString();
                rs.correo_electronico = read["correo_electronico"].ToString();
                rs.CuentaBancaria = Convert.ToInt32(read["CuentaBancaria"]);
                rs.FechaSolicitud = read["FechaSolicitud"].ToString();
                //rs.IdBeca = Convert.ToInt32(read["IdBeca"]) ;
                rs.IdCarnet = read["IdCarnet"].ToString();
                rs.IdCurso = Convert.ToInt32(read["IdCurso"]);
                //rs.IdDep = Convert.ToInt32(read["IdDep"]);
                rs.IdEstado = Convert.ToInt32(read["IdEstado"]);
                //rs.IdForm = Convert.ToInt32(read["IdForm"]);
                rs.IdFormulario = Convert.ToInt32(read["IdFormulario"]);
                rs.IdSolicitud = Convert.ToInt32(read["IdSolicitud"]);
                rs.ImgCedula = read["ImgCedula"].ToString();
                rs.ImgCuentaBancaria = read["ImgCuentaBancaria"].ToString();
                rs.ImgPromedioPonderado = read["ImgPromedioPonderado"].ToString();
                rs.ImgPromedioPonderadoGeneral = read["ImgPromedioGeneral"].ToString();
                rs.Observacion = read["Observacion"].ToString();
                rs.OtraBeca = read["OtraBeca"].ToString();
                rs.OtraBecaHoras = Convert.ToInt32(read["OtraBecaHoras"]);
                rs.PeriodoSolicitud = read["PeriodoSolicitud"].ToString();
                rs.primer_apellido = read["primer_apellido"].ToString();
                rs.primer_nombre = read["primer_nombre"].ToString();
                rs.PromedioCurso = Convert.ToInt32(read["PromedioCurso"]);
                rs.PromedioPonderado = Convert.ToInt32(read["PromedioPonderadoAnterior"]);
                rs.PromedioPonderadoGen = Convert.ToInt32(read["PromedioPonderadoGeneral"]);
                rs.segundo_apellido = read["segundo_apellido"].ToString();
                rs.segundo_nombre = read["segundo_nombre"].ToString();
                rs.Tel = read["Telefono"].ToString();


                ListRS.Add(rs);

            }
            read.Close();


            conn.Close();
            return ListRS;

        }
        
        public List<Cancelacion> GetAllCancelaciones(int Estado)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            List<Cancelacion> ListSolicitud = new List<Cancelacion>();

            command = new SqlCommand("select S.IdCarnet , S.Observacion, TB.Nombre, E.primer_nombre, E.segundo_nombre , E.primer_apellido, E.segundo_apellido from Solicitud as S inner join estudiantes as E on E.carne = S.IdCarnet inner join SolicitudxFormulario as SF on SF.IdSolicitud = S.IdSolicitud inner join Formulario as F on SF.IdFormulario = F.IdFormulario inner join TipoBeca as TB on TB.IdTipoBeca = F.IdTipoBeca where S.[Delete] = 0 and S.IdEstado = "+ Estado.ToString(), conn);
            read = command.ExecuteReader();
            while (read.Read())
            {
                Cancelacion sol = new Cancelacion();
                sol.IdCarnet = read["IdCarnet"].ToString();
                sol.TBNombre = read["Nombre"].ToString();
                sol.Nombre1 = read["primer_nombre"].ToString();
                sol.Nombre2 = read["segundo_nombre"].ToString();
                sol.Apellido1 = read["primer_apellido"].ToString();
                sol.Apellido2 = read["segundo_apellido"].ToString();
                sol.Observacion = read["Observacion"].ToString();

                ListSolicitud.Add(sol);

            }
            read.Close();


            conn.Close();
            return ListSolicitud;
        }

        /// <summary>
        /// 
        /// Metodo que se utiliza para obtener las solicitudes aprobadas o rechazadas
        /// 
        /// </summary>
        /// <param name="Estado"></param>
        /// <returns></returns>

        public List<Requisitos> GetAllAprobadasRechazadas (int Estado)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            List<Requisitos> ListSolicitud = new List<Requisitos>();

            command = new SqlCommand("select S.IdCarnet , S.Observacion, TB.Nombre, E.primer_nombre, E.segundo_nombre , E.primer_apellido, E.segundo_apellido from Solicitud as S inner join EstadoSolicitud as ES on S.IdEstado = ES.IdEstado inner join estudiantes as E on E.carne = S.IdCarnet inner join EstudiantexFormulario as EF on EF.IdCarnet = E.carne inner join Formulario as F on EF.IdFormulario = F.IdFormulario inner join TipoBeca as TB on TB.IdTipoBeca = F.IdTipoBeca where S.[Delete] = 0 and  S.IdEstado =" + Estado.ToString(), conn);
            read = command.ExecuteReader();
            while (read.Read())
            {
                Requisitos sol = new Requisitos();
                sol.IdCarnet = read["IdCarnet"].ToString();
                sol.TBNombre = read["Nombre"].ToString();
                sol.Nombre1 = read["primer_nombre"].ToString();
                sol.Nombre2 = read["segundo_nombre"].ToString();
                sol.Apellido1 = read["primer_apellido"].ToString();
                sol.Apellido2 = read["segundo_apellido"].ToString();

                ListSolicitud.Add(sol);

            }
            read.Close();


            conn.Close();
            return ListSolicitud;
        }

        public void CancelarSolicitudEstudiante(int IdSolicitud)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;

            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();

            SqlParameter idsolicitud = new SqlParameter("@IS", System.Data.SqlDbType.Int);
            idsolicitud.Value = IdSolicitud;

            command = new SqlCommand("EXEC CancelarSolicitudEstudiante @IdSolicitud=@IS  ", conn);
            command.Parameters.Add(idsolicitud);
           

            command.ExecuteNonQuery();


            conn.Close();


        }

        public void CancelarSolicitudUsuario(int IdSolicitud)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;

            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();

            SqlParameter idsolicitud = new SqlParameter("@IS", System.Data.SqlDbType.Int);
            idsolicitud.Value = IdSolicitud;

            command = new SqlCommand("EXEC CancelarSolicitudUsuario @IdSolicitud=@IS  ", conn);
            command.Parameters.Add(idsolicitud);


            command.ExecuteNonQuery();


            conn.Close();


        }

        public List<Solicitud> GetAllSolicitudesEstudiante(string Estudiante)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            List<Solicitud> ListSolicitud = new List<Solicitud>();

            command = new SqlCommand("select S.IdCarnet,S.IdSolicitud, TB.IdTipoBeca, TB.Nombre, S.IdEstado from Solicitud as S inner join estudiantes as E on E.carne = S.IdCarnet inner join EstudiantexFormulario as EF on E.carne = EF.IdCarnet inner join Formulario as F on EF.IdFormulario = F.IdFormulario inner join TipoBeca as TB on TB.IdTipoBeca = F.IdTipoBeca where S.[Delete] = 0 and S.IdCarnet = '" + Estudiante.ToString() + "'", conn);
            read = command.ExecuteReader();
            while (read.Read())
            {
                Solicitud sol = new Solicitud();
                sol.IdCarnet = read["IdCarnet"].ToString();
                sol.IdSolicitud = Convert.ToInt32( read["IdSolicitud"]);
                sol.IdTipoBeca = Convert.ToInt32(read["IdTipoBeca"]);
                sol.NombreBeca = read["Nombre"].ToString();
                sol.IdEstado = Convert.ToInt32(read["IdEstado"]);

                ListSolicitud.Add(sol);

            }
            read.Close();


            conn.Close();
            return ListSolicitud;


        }

        public void AceptarSolicitud(int IdSolicitud,int IdUsuario)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;

            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();

            SqlParameter idsolicitud = new SqlParameter("@IS", System.Data.SqlDbType.Int);
            idsolicitud.Value = IdSolicitud;

            SqlParameter idusuario = new SqlParameter("@IU", System.Data.SqlDbType.Int);
            idsolicitud.Value = IdSolicitud;


            command = new SqlCommand("EXEC AceptarSolicitudUsuario @IdSolicitud=@IS, @IdUsuario = @IU ", conn);
            command.Parameters.Add(idsolicitud);
            command.Parameters.Add(idusuario);


            command.ExecuteNonQuery();


            conn.Close();


        }


    }
}