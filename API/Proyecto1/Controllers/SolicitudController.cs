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
    [RoutePrefix("api/Solicitud")]
    public class SolicitudController : ApiController
    {
       /* [HttpPost]
        [Route("GuardarForm")]
        public void PostSucursal([FromBody] Formulario form)
        {
            FormularioService con = new FormularioService();
            con.GuardarForm(form);
        }*/
        [HttpGet]
        [Route("GetAllSolicitudes")]
        public IHttpActionResult GetAllSolicitudes()
        {
            SolicitudService con = new SolicitudService();
            return Ok(con.GetAllSolicitudes());
        }

        
        [HttpGet]
        [Route("GetSolicitudesRevision")]
        public IHttpActionResult GetSolicitudesRevision(int TipoBeca)
        {
            SolicitudService con = new SolicitudService();
            return Ok(con.GetSolicitudesRevision(TipoBeca));
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