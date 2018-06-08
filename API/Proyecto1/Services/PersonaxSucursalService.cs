﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto1.Classes;
using System.Web.Http;
using System.Data.SqlClient;

namespace Proyecto1.Services
{
    public class PersonaxSucursalService
    {
        public List<PersonaxSucursal> GetAllPersonasxSucursal()
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;

            conn = new SqlConnection("Data Source=(local);Initial Catalog=Proyecto1;Integrated Security=True");
            conn.Open();
            command = new SqlCommand("SELECT *  from PersonaxSucursal where LogicDelete = 0", conn);
            read = command.ExecuteReader();

            List<PersonaxSucursal> ListPersonaxSucursal = new List<PersonaxSucursal>();
            while (read.Read())
            {
                PersonaxSucursal personaxSucursal = new PersonaxSucursal();
                personaxSucursal.IdCedula = Convert.ToInt32(read["IdCedula"]);
                personaxSucursal.IdSucursal = Convert.ToInt32(read["IdSucursal"]);
                personaxSucursal.SalarioHora = Convert.ToInt32(read["SalarioHora"]);
                personaxSucursal.LogicDelete = Convert.ToBoolean(read["LogicDelete"]);

                ListPersonaxSucursal.Add(personaxSucursal);

            }
            read.Close();
            conn.Close();
            return ListPersonaxSucursal;
        }

        public PersonaxSucursal GetPersonaxSucursal(int id)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;
            SqlDataReader read;

            conn = new SqlConnection("Data Source=(local);Initial Catalog=Proyecto1;Integrated Security=True");
            conn.Open();
            command = new SqlCommand("SELECT *  from PersonaxSucursal where LogicDelete = 0 and IdCedula=" + id.ToString(), conn);
            read = command.ExecuteReader();

            PersonaxSucursal persona = new PersonaxSucursal();
            while (read.Read())
            {
                persona.IdCedula = Convert.ToInt32(read["IdCedula"]);
                persona.SalarioHora = Convert.ToInt32(read["SalarioHora"]);
                persona.LogicDelete = Convert.ToBoolean(read["LogicDelete"]);
            }
            read.Close();
            conn.Close();
            return persona;
        }

        public void PostPersonaxSucursal([FromBody] PersonaxSucursal personaxSucursal)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;

            conn = new SqlConnection("Data Source=(local);Initial Catalog=Proyecto1;Integrated Security=True");
            conn.Open();

            SqlParameter IdCedula = new SqlParameter("@IdCedula", System.Data.SqlDbType.Int);
            IdCedula.Value = personaxSucursal.IdCedula;

            SqlParameter IdSucursal = new SqlParameter("@IdSucursal", System.Data.SqlDbType.Int);
            IdSucursal.Value = personaxSucursal.IdSucursal;

            SqlParameter SalarioHora = new SqlParameter("@SalarioHora", System.Data.SqlDbType.Int);
            SalarioHora.Value = personaxSucursal.SalarioHora;

            command = new SqlCommand("insert into PersonaxSucursal(IdCedula,IdSucursal,SalarioHora) VALUES (@IdCedula,@IdSucursal,@SalarioHora)", conn);
            command.Parameters.Add(IdCedula);
            command.Parameters.Add(IdSucursal);
            command.Parameters.Add(SalarioHora);
            command.ExecuteNonQuery();

            conn.Close();

        }

        public void DeletePersonaxSucursal([FromBody] int cedula)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;

            conn = new SqlConnection("Data Source=(local);Initial Catalog=Proyecto1;Integrated Security=True");
            conn.Open();

            command = new SqlCommand("UPDATE PersonaxSucursal SET LogicDelete = 1  WHERE IdCedula=" + cedula.ToString(), conn);
            command.ExecuteNonQuery();
            conn.Close();

        }

        public void UpdatePersonaxSucursal([FromBody] PersonaxSucursal rol)
        {
            System.Data.SqlClient.SqlConnection conn;
            SqlCommand command;

            conn = new SqlConnection("Data Source=(local);Initial Catalog=Proyecto1;Integrated Security=True");
            conn.Open();
            String comm = "Update PersonaxSucursal SET SalarioHora=" + rol.SalarioHora + " WHERE IdCedula=" + rol.IdCedula;


            command = new SqlCommand(comm, conn);

            command.ExecuteNonQuery();
            conn.Close();

        }
    }
}