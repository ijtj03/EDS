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
    [RoutePrefix("api/Departamentos")]
    public class DepartamentoController : ApiController
    {
        [HttpGet]
        [Route("GetAllDeps")]
        public IHttpActionResult GetAllDeps()
        {
            DepartamentoService con = new DepartamentoService();
            return Ok(con.GetAllDeps());
        }
    }
}