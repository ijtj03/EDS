using Proyecto1.Classes;
using Proyecto1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proyecto1.Controllers
{
    [RoutePrefix("api/Varios")]
    public class VariosController : ApiController
    {
        [HttpGet]
        [Route("GetTiposBeca")]
        public IHttpActionResult GetTiposBeca()
        {
            VariosService con = new VariosService();
            return Ok(con.GetTiposBeca());
        }
        [HttpGet]
        [Route("GetAllDeps")]
        public IHttpActionResult GetAllDeps()
        {
            VariosService con = new VariosService();
            return Ok(con.GetAllDeps());
        }
        [HttpGet]
        [Route("GetAllEnc")]
        public IHttpActionResult GetAllUsers()
        {
            VariosService con = new VariosService();
            return Ok(con.GetAllUsers());
        }
        [HttpGet]
        [Route("GetAllCursos")]
        public IHttpActionResult GetAllCursos()
        {
            VariosService con = new VariosService();
            return Ok(con.GetAllCursos());
        }
        [HttpGet]
        [Route("GetRoles")]
        public IHttpActionResult GetRoles()
        {
            VariosService con = new VariosService();
            return Ok(con.GetRoles());
        }
    }
}