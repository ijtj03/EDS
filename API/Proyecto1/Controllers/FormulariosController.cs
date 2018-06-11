using Proyecto1.Classes;
using Proyecto1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Proyecto1.Controllers
{
    [RoutePrefix("api/Formularios")]
    public class FormulariosController : ApiController
    {
        [HttpPost]
        [Route("GuardarForm")]
        public IHttpActionResult GuardarForm([FromBody] Formulario form)
        {
            FormularioService con = new FormularioService();
            con.GuardarForm(form);
            return Ok();
        }
        [HttpGet]
        [Route("GetAllForms")]
        public IHttpActionResult GetAllForms()
        {
            FormularioService con = new FormularioService();
            return Ok(con.GetAllForms());
        }
        [HttpGet]
        [Route("GetFormulariosGuardados")]
        public IHttpActionResult GetFormulariosGuardados(int estudiante)
        {
            FormularioService con = new FormularioService();
            return Ok(con.GetFormulariosGuardados(estudiante));
        }
        [HttpPost]
        [Route("ActualizarFormularioGuardado")]
        public IHttpActionResult ActualizarFormularioGuardado([FromBody] Formulario form)
        {
            FormularioService con = new FormularioService();
            
            return Ok(con.ActualizarFormularioGuardado(form));
        }
        [HttpGet]
        [Route("EnviarForm")]
        public IHttpActionResult EnviarForm(int IdFormulario, int IdCarnet, string Periodo)
        {
            FormularioService con = new FormularioService();
            con.EnviarForm(IdFormulario, IdCarnet, Periodo);
            return Ok();
        }

        [HttpPost]
        [Route("ActualizarFormularioEnviado")]
        public IHttpActionResult ActualizarFormularioEnviado([FromBody] Formulario form)
        {
            FormularioService con = new FormularioService();

            return Ok(con.ActualizarFormularioEnviado(form));
        }
    }
}