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
        

        [HttpGet]
        [Route("GetAllCancelaciones")]
        public IHttpActionResult GetAllCancelaciones(int Estado)
        {
            SolicitudService con = new SolicitudService();
            return Ok(con.GetAllCancelaciones(Estado));
        }

        [HttpGet]
        [Route("GetAllAprobadasRechazadas")]
        public IHttpActionResult GetAllAprobadasRechazadas(int Estado)
        {
            SolicitudService con = new SolicitudService();
            return Ok(con.GetAllAprobadasRechazadas(Estado));
        }

        
        [HttpGet]
        [Route("GetAllSolicitudesEstudiante")]
        public IHttpActionResult GetAllSolicitudesEstudiante(string Estudiante)
        {
            SolicitudService con = new SolicitudService();
            return Ok(con.GetAllSolicitudesEstudiante(Estudiante));
        }

        [HttpPost]
        [Route("CancelarSolicitudEstudiante")]
        public IHttpActionResult CancelarSolicitudEstudiante(int IdSolicitud)
        {
            SolicitudService con = new SolicitudService();

            con.CancelarSolicitudEstudiante(IdSolicitud);
            return Ok();
        }

        [HttpPost]
        [Route("CancelarSolicitudUsuario")]
        public IHttpActionResult CancelarSolicitudUsuario(int IdSolicitud)
        {
            SolicitudService con = new SolicitudService();

            con.CancelarSolicitudUsuario(IdSolicitud);
            return Ok();
        }

        [HttpPost]
        [Route("AceptarSolicitudUsuario")]
        public IHttpActionResult AceptarSolicitud(int IdSolicitud, int IdUsuario)
        {
            SolicitudService con = new SolicitudService();

            con.AceptarSolicitud(IdSolicitud,IdUsuario);
            return Ok();
        }



    }
}