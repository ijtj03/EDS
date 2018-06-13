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
    [RoutePrefix("api/Parametros")]
    public class ParametroController : ApiController
    {
        [HttpPost]
        [Route("ActualizarParametros")]
        public IHttpActionResult ActualizarParametro([FromBody] Parametro param)
        {
            ParametroService con = new ParametroService();

            return Ok(con.ActualizarParametros(param));
        }

        [HttpPost]
        [Route("GuardarParametros")]
        public IHttpActionResult GuardarParametros([FromBody] Parametro param)
        {
            ParametroService con = new ParametroService();

            return Ok(con.GuardarParametros(param));
        }
        [HttpGet]
        [Route("GetLast")]
        public IHttpActionResult GetLast()
        {
            ParametroService con = new ParametroService();

            return Ok(con.GetLast());
        }
    }
}