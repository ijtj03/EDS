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
    [RoutePrefix("api/Estudiante")]
    public class EstudianteController : ApiController
    {
       /* [HttpPost]
        [Route("GuardarForm")]
        public void PostSucursal([FromBody] Formulario form)
        {
            FormularioService con = new FormularioService();
            con.GuardarForm(form);
        }*/
        [HttpGet]
        [Route("GetAllEstudiantes")]
        public IHttpActionResult GetAllSolicitudes()
        {
            EstudianteService con = new EstudianteService();
            return Ok(con.GetAllEstudiantes());
        }

        
        /* [HttpGet]
         [Route("GetFormulariosGuardados")]
         public IHttpActionResult GetFormulariosGuardados(int estudiante)
         {
             FormularioService con = new FormularioService();
             return Ok(con.GetFormulariosGuardados(estudiante));
         }*/
    }
}