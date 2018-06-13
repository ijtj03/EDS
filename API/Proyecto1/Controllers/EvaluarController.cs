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
    [RoutePrefix("api/Evaluar")]
    public class EvaluarController : ApiController
    {
        [HttpGet]
        [Route("GetEstudiantesxEvaluar")]
        public IHttpActionResult GetEstudiantesxUsuario(int encargado)
        {
            EvaluarService con = new EvaluarService();
            return Ok(con.GetEstudiantesxUsuario(encargado));
        }
        [HttpPost]
        [Route("EvaluarEstudiante")]
        public IHttpActionResult GuardarEvaluacion([FromBody] Evaluacion evaluacion)
        {
            EvaluarService con = new EvaluarService();
            con.GuardarEvaluacion(evaluacion);
            return Ok();
        }
        [HttpGet]
        [Route("GetAllEvaluaciones")]
        public IHttpActionResult GetAllEvaluaciones()
        {
            EvaluarService con = new EvaluarService();
            return Ok(con.GetAllEvaluaciones());
        }
    }

}