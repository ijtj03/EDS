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
        public IHttpActionResult AceptarSolicitud(int IdSolicitud, int IdUsuario,int hAs)
        {
            SolicitudService con = new SolicitudService();

            con.AceptarSolicitud(IdSolicitud,IdUsuario, hAs);
            return Ok();
        }

        [HttpPost]
        [Route("RechazarSolicitud")]
        public IHttpActionResult RechazarSolicitud(int idSolicitud)
        {
            SolicitudService con = new SolicitudService();

            con.RechazarSolicitud(idSolicitud);
            return Ok();
        }

        [HttpPost]
        [Route("ReplicarSolicitud")]
        public IHttpActionResult ReplicarSolicitud(int IdSolicitud)
        {
            SolicitudService con = new SolicitudService();
            con.ReplicarSolicitud(IdSolicitud);
            return Ok();
        }

        [HttpPost]
        [Route("EstadoNoCumple")]
        public IHttpActionResult EstadoNoCumple(Observacion observacion)
        {
            SolicitudService con = new SolicitudService();
            con.EstadoNoCumple(observacion);
            return Ok();
        }

        [HttpPost]
        [Route("EstadoCumple")]
        public IHttpActionResult EstadoCumple(Observacion observacion)
        {
            SolicitudService con = new SolicitudService();
            con.EstadoCumple(observacion);
            return Ok();
        }
        [HttpGet]
        [Route("GetSolComision")]
        public IHttpActionResult GetSolComision()
        {
            SolicitudService con = new SolicitudService();
            return Ok(con.GetSolComision());
        }


    }
}