using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Classes;
using System.Web.Http;
using System.Data.SqlClient;


namespace Proyecto1.Services
{
    public class FormularioService
    {
        public void GuardarForm([FromBody] Formulario form)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;

            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();

            SqlParameter IdCurso = new SqlParameter("@IdCur", System.Data.SqlDbType.Int);
            IdCurso.Value = form.IdCurso;

            SqlParameter IdForm = new SqlParameter("@IdForm", System.Data.SqlDbType.Int);
            IdForm.Value = form.IdForm;

            SqlParameter CuentaBancaria = new SqlParameter("@CB", System.Data.SqlDbType.Int);
            CuentaBancaria.Value = form.CuentaBancaria;

            SqlParameter IdDepartamento = new SqlParameter("@IdDep", System.Data.SqlDbType.Int);
            IdDepartamento.Value = form.IdDep;

            SqlParameter Telefono = new SqlParameter("@Tel", System.Data.SqlDbType.VarChar);
            Telefono.Value = form.Tel;

            SqlParameter Carnet = new SqlParameter("@Carnet", System.Data.SqlDbType.VarChar);
            Carnet.Value = form.Carnet;

            SqlParameter ImgCuentaBancaria = new SqlParameter("@ICB", System.Data.SqlDbType.VarChar);
            ImgCuentaBancaria.Value = form.ImgCuentaBancaria;

            SqlParameter ImgPromPonderado = new SqlParameter("@IPPA", System.Data.SqlDbType.VarChar);
            ImgPromPonderado.Value = form.ImgPromedioPonderadoAnterios;

            SqlParameter ImgPromPonderadoGen = new SqlParameter("@IPPG", System.Data.SqlDbType.VarChar);
            ImgPromPonderadoGen.Value = form.ImgPromedioPonderadoGeneral;

            SqlParameter ImgCedula = new SqlParameter("@IC", System.Data.SqlDbType.VarChar);
            ImgCedula.Value = form.ImgCedula;

            SqlParameter OtraBeca = new SqlParameter("@OB", System.Data.SqlDbType.VarChar);
            OtraBeca.Value = form.OtraBeca;

            SqlParameter Cedula = new SqlParameter("@Ced", System.Data.SqlDbType.VarChar);
            Cedula.Value = form.Cedula;

            SqlParameter OtraBecaHoras = new SqlParameter("@OBH", System.Data.SqlDbType.Int);
            OtraBecaHoras.Value = form.OtraBecaHoras;

            SqlParameter IdBeca = new SqlParameter("@IdBeca", System.Data.SqlDbType.Int);
            IdBeca.Value = form.IdBeca;

            SqlParameter Correo = new SqlParameter("@Corr", System.Data.SqlDbType.VarChar);
            Correo.Value = form.Correo;

            SqlParameter PromedioCurso = new SqlParameter("@PC", System.Data.SqlDbType.Decimal);
            PromedioCurso.Value = form.PromedioCurso;

            SqlParameter PromedioPonderadoAnterior = new SqlParameter("@PPA", System.Data.SqlDbType.Decimal);
            PromedioPonderadoAnterior.Value = form.PromedioPonderadoAnterior;

            SqlParameter PromedioPonderadoGenenral = new SqlParameter("@PPG", System.Data.SqlDbType.Decimal);
            PromedioPonderadoGenenral.Value = form.PromedioPonderadoGen;


            command = new SqlCommand("EXEC GuardarFormulario @IdFormulario=@IdForm, @IdCurso=@IdCur,@IdDepartamento=@IdDep,@IdTipoBeca=@IdBeca,@Telefono=@Tel,@Correo=@Corr,@PromedioCurso=@PC,@PromedioPonderadoAnterior=@PPA,@PromedioPonderadoGeneral=@PPG,@CuentaBancaria=@CB, @ImgCuentaBancaria=@ICB, @ImgPromedioPonderado=@IPPA, @ImgPromedioGeneral=@IPPG, @ImgCedula=@IC, @OtraBeca=@OB, @OtraBecaHoras=@OBH, @Cedula=@Ced,@Carne=@Carnet", conn);
            command.Parameters.Add(IdCurso);
            command.Parameters.Add(IdBeca);
            command.Parameters.Add(IdForm);
            command.Parameters.Add(IdDepartamento);
            command.Parameters.Add(CuentaBancaria);
            command.Parameters.Add(ImgCedula);
            command.Parameters.Add(ImgCuentaBancaria);
            command.Parameters.Add(ImgPromPonderadoGen);
            command.Parameters.Add(ImgPromPonderado);
            command.Parameters.Add(Cedula);
            command.Parameters.Add(OtraBeca);
            command.Parameters.Add(OtraBecaHoras);
            command.Parameters.Add(Correo);
            command.Parameters.Add(PromedioCurso);
            command.Parameters.Add(PromedioPonderadoAnterior);
            command.Parameters.Add(PromedioPonderadoGenenral);
            command.Parameters.Add(Telefono);
            command.Parameters.Add(Carnet);
            command.ExecuteNonQuery();

            conn.Close();

        }

        internal List<Formulario> GetAllForms()
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            List<Formulario> ListForms = new List<Formulario>();
          
                command = new SqlCommand("SELECT *  from Formulario", conn);
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
            
            
            conn.Close();
            return ListForms;
        }
    }
}