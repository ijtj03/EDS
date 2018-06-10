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
    [RoutePrefix("api/Calificar")]
    public class CalificarController : ApiController
    {
        [HttpGet]
        [Route("GetEstudiantesxUsuario")]
        public IHttpActionResult GetEstudiantesxUsuario(int encargado)
        {
            CalificarService con = new CalificarService();
            return Ok(con.GetEstudiantesxUsuario(encargado));
        }
    }
}