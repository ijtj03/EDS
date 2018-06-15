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
        public void GuardarEliFormGuardad0Form(int idForm)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;

            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            command = new SqlCommand("update EstudiantexFormulario set [Delete]=1 where IdFormulario=" + idForm.ToString(), conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
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
            ImgPromPonderado.Value = form.ImgPromedioPonderadoAnterior;

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


            command = new SqlCommand("EXEC GuardarFormulario @IdCurso=@IdCur,@IdDepartamento=@IdDep,@IdTipoBeca=@IdBeca,@Telefono=@Tel,@Correo=@Corr,@PromedioCurso=@PC,@PromedioPonderadoAnterior=@PPA,@PromedioPonderadoGeneral=@PPG,@CuentaBancaria=@CB, @ImgCuentaBancaria=@ICB, @ImgPromedioPonderado=@IPPA, @ImgPromedioGeneral=@IPPG, @ImgCedula=@IC, @OtraBeca=@OB, @OtraBecaHoras=@OBH, @Cedula=@Ced,@Carne=@Carnet", conn);

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

        public Int32 ActualizarFormularioGuardado(Formulario form)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            command = new SqlCommand("EXEC ActualizarFormulario @IdFormulario=@IdForm,@Carne=@Carnet,@Telefono=@Tel,@Correo=@C,@PromedioCurso = @PC,@PromedioPonderadoAnterior = @PPA,@PromedioPonderadoGeneral = @PPG,@CuentaBancaria = @CB, @ImgCuentaBancaria = @ICB, @ImgPromedioPonderado = @IPPA, @ImgPromedioGeneral = @IPPG, @ImgCedula = @IC, @OtraBeca = @OB, @OtraBecaHoras = @OBH, @Cedula = @Ced", conn);

            command.Parameters.AddWithValue("@IdForm", form.IdForm);
            Console.WriteLine(form.IdForm);
            command.Parameters.AddWithValue("@Carnet", form.Carnet);
            Console.WriteLine(form.Carnet);
            command.Parameters.AddWithValue("@Tel", form.Tel);
            command.Parameters.AddWithValue("@C", form.Correo);
            command.Parameters.AddWithValue("@PC", form.PromedioCurso);
            command.Parameters.AddWithValue("@PPA", form.PromedioPonderadoAnterior);
            command.Parameters.AddWithValue("@PPG", form.PromedioPonderadoGen);
            command.Parameters.AddWithValue("@CB", form.CuentaBancaria);
            command.Parameters.AddWithValue("@ICB", form.ImgCuentaBancaria);
            command.Parameters.AddWithValue("@IC", form.ImgCedula);
            command.Parameters.AddWithValue("@IPPA", form.ImgPromedioPonderadoAnterior);
            command.Parameters.AddWithValue("@IPPG", form.ImgPromedioPonderadoGeneral);
            command.Parameters.AddWithValue("@OB", form.OtraBeca);
            command.Parameters.AddWithValue("@OBH", form.OtraBecaHoras);
            command.Parameters.AddWithValue("@Ced", form.Cedula);
            Int32 r = command.ExecuteNonQuery();

            conn.Close();
            return r;
        }
        public Int32 ActualizarFormularioEnviado(Formulario form)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();
            command = new SqlCommand("EXEC ActualizarFormularioEnviado @IdFormulario=@IdForm,@Carne=@Carnet,@Telefono=@Tel,@Correo=@C,@PromedioCurso = @PC,@PromedioPonderadoAnterior = @PPA,@PromedioPonderadoGeneral = @PPG,@CuentaBancaria = @CB, @ImgCuentaBancaria = @ICB, @ImgPromedioPonderado = @IPPA, @ImgPromedioGeneral = @IPPG, @ImgCedula = @IC, @OtraBeca = @OB, @OtraBecaHoras = @OBH, @Cedula = @Ced", conn);

            command.Parameters.AddWithValue("@IdForm", form.IdForm);
            command.Parameters.AddWithValue("@Carnet", form.Carnet);
            command.Parameters.AddWithValue("@Tel", form.Tel);
            command.Parameters.AddWithValue("@C", form.Correo);
            command.Parameters.AddWithValue("@PC", form.PromedioCurso);
            command.Parameters.AddWithValue("@PPA", form.PromedioPonderadoAnterior);
            command.Parameters.AddWithValue("@PPG", form.PromedioPonderadoGen);
            command.Parameters.AddWithValue("@CB", form.CuentaBancaria);
            command.Parameters.AddWithValue("@ICB", form.ImgCuentaBancaria);
            command.Parameters.AddWithValue("@IC", form.ImgCedula);
            command.Parameters.AddWithValue("@IPPA", form.ImgPromedioPonderadoAnterior);
            command.Parameters.AddWithValue("@IPPG", form.ImgPromedioPonderadoGeneral);
            command.Parameters.AddWithValue("@OB", form.OtraBeca);
            command.Parameters.AddWithValue("@OBH", form.OtraBecaHoras);
            command.Parameters.AddWithValue("@Ced", form.Cedula);
            Int32 r = command.ExecuteNonQuery();

            conn.Close();
            return r;
        }

        public List<Formulario> GetFormulariosGuardados(int estudiante)
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

            command = new SqlCommand("Select EF.IdFormulario,F.OtraBecaHoras,EF.IdCarnet,F.IdCurso,F.IdDepartamento,F.IdTipoBeca,F.Telefono,F.Correo,F.PromedioCurso,F.PromedioPonderadoAnterior,F.PromedioPonderadoGeneral,F.CuentaBancaria,F.ImgCedula,F.ImgCuentaBancaria,F.ImgPromedioGeneral,F.ImgPromedioPonderado,F.OtraBeca,F.Cedula from Formulario as F inner join EstudiantexFormulario as EF on F.IdFormulario=EF.IdFormulario where EF.[Delete] = 0 and F.[Delete] = 0 and EF.IdCarnet=" + estudiante.ToString(), conn);
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
                persona.PromedioCurso = Convert.ToDecimal(read["PromedioCurso"]);
                persona.PromedioPonderadoAnterior = Convert.ToDecimal(read["PromedioPonderadoAnterior"]);
                persona.PromedioPonderadoGen = Convert.ToDecimal(read["PromedioPonderadoGeneral"]);
                persona.CuentaBancaria = Convert.ToInt32(read["CuentaBancaria"]);
                persona.ImgCuentaBancaria = read["ImgCuentaBancaria"].ToString();
                persona.ImgPromedioPonderadoAnterior = read["ImgPromedioPonderado"].ToString();
                persona.ImgPromedioPonderadoGeneral = read["ImgPromedioGeneral"].ToString();
                persona.ImgCedula = read["ImgCedula"].ToString();
                persona.OtraBeca = read["OtraBeca"].ToString();
                persona.OtraBecaHoras = Convert.ToInt32(read["OtraBecaHoras"]);
                persona.Cedula = read["Cedula"].ToString();
                switch (persona.IdBeca)
                {
                    case 1:
                        persona.TipoBeca = "Horas Estudiante";
                        break;
                    case 2:
                        persona.TipoBeca = "Horas Asistente";
                        break;
                    case 3:
                        persona.TipoBeca = "Tutoria Estudiantil";
                        break;
                    case 4:
                        persona.TipoBeca = "Asistencia Especial";
                        break;
                    default:
                        {
                            persona.TipoBeca="NA";
                            break;
                        }

                }


                ListForms.Add(persona);

            }
            read.Close();


            conn.Close();
            return ListForms;
        }

        public List<Formulario> GetAllForms()
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
          
                command = new SqlCommand("SELECT *  from Formulario where [Delete] = 0", conn);
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
                    persona.ImgPromedioPonderadoAnterior = read["ImgPromedioPonderado"].ToString();
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
        public void EnviarForm(int IdFormulario, int IdCarnet, string Periodo)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;

            var conString = System.Configuration.
                ConfigurationManager.ConnectionStrings["HorasBecaAPI"];
            string strConnString = conString.ConnectionString;

            conn = new SqlConnection(strConnString);
            conn.Open();

            SqlParameter formulario = new SqlParameter("@IF", System.Data.SqlDbType.Int);
            formulario.Value = IdFormulario;

            SqlParameter carnet = new SqlParameter("@IC", System.Data.SqlDbType.Int);
            carnet.Value = IdCarnet;

            SqlParameter periodo = new SqlParameter("@P", System.Data.SqlDbType.VarChar);
            periodo.Value = Periodo;

            command = new SqlCommand("EXEC EnviarFormulario @IdFormulario=@IF , @IdCarnet = @IC , @Periodo = @P ", conn);
            command.Parameters.Add(formulario);
            command.Parameters.Add(carnet);
            command.Parameters.Add(periodo);

            command.ExecuteNonQuery();


            conn.Close();
        }

        public void GuardarEnviarForm([FromBody] Formulario form)
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
            ImgPromPonderado.Value = form.ImgPromedioPonderadoAnterior;

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

            SqlParameter Periodo = new SqlParameter("@P", System.Data.SqlDbType.VarChar);
            Periodo.Value = form.Periodo;


            command = new SqlCommand("EXEC GuardarEnviarFormulario @IdCurso=@IdCur,@IdDepartamento=@IdDep,@IdTipoBeca=@IdBeca,@Telefono=@Tel,@Correo=@Corr,@PromedioCurso=@PC,@PromedioPonderadoAnterior=@PPA,@PromedioPonderadoGeneral=@PPG,@CuentaBancaria=@CB, @ImgCuentaBancaria=@ICB, @ImgPromedioPonderado=@IPPA, @ImgPromedioGeneral=@IPPG, @ImgCedula=@IC, @OtraBeca=@OB, @OtraBecaHoras=@OBH, @Cedula=@Ced,@Carne=@Carnet,@Periodo=@P", conn);

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



    }
}