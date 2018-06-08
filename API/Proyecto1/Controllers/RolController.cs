﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Proyecto1.Services;
using Proyecto1.Classes;

namespace Proyecto1.Controllers
{
    [RoutePrefix("api/Rol")]
    public class RolController : ApiController
    {

        [HttpGet]
        [Route("GetAllRol")]
        public IHttpActionResult GetAllRoles()
        {
            RolService con = new RolService();
            return Ok(con.GetAllRoles());
        }

        [HttpGet]
        [Route("GetAllRolN")]
        public IHttpActionResult GetAllRolesN()
        {
            RolService con = new RolService();
            return Ok(con.GetAllRolesN());
        }


        [HttpGet]
        [Route("GetIdRol")]
        public IHttpActionResult GetIdRol(String nombre)
        {
            RolService con = new RolService();
            return Ok(con.GetIdRol(nombre));
        }

        [HttpGet]
        [Route("GetNombreRol")]
        public IHttpActionResult GetNombreRol(int id)
        {
            RolService con = new RolService();
            return Ok(con.GetNombreRol(id));
        }

        


        [HttpGet]
        [Route("GetRol")]
        public IHttpActionResult GetRoll(int id)
        {
            RolService con = new RolService();
            return Ok(con.GetRol(id));
        }

        [HttpPut]
        [Route("PutLogicDelete")]
        public void DeleteRol([FromBody] int id)
        {
            RolService con = new RolService();
            con.DeleteRol(id);
        }

        [HttpPost]
        [Route("PostRol")]
        public void PostMedicamento([FromBody] Rol rol)
        {
            RolService con = new RolService();
            con.PostRol(rol);
        }

        [HttpPost]
        [Route("UpdateRol")]
        public void UpdateRol([FromBody] Rol rol)
        {
            RolService con = new RolService();
            con.UpdateRol(rol);
        }

    }
}
