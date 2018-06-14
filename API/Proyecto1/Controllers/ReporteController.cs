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
    [RoutePrefix("api/Reporte")]
    public class ReporteController : ApiController
    {
        
        [HttpGet]
        [Route("GetReporteInicial")]
        public IHttpActionResult GetReporteInicial(int anno, string beca,string periodo)
        {
            
                ReporteService con = new ReporteService();
                return Ok(con.GetReporteInicialxTipoBeca(anno,periodo,beca)); 
        }

        [HttpGet]
        [Route("GetReporteInicialGeneral")]
        public IHttpActionResult GetReporteInicialGeneral(int anno, string periodo)
        {
            ReporteService con = new ReporteService();
            return Ok(con.GetReporteInicialGeneral(anno, periodo));
        }

        [HttpGet]
        [Route("GetReporteFinal")]
        public IHttpActionResult GetReporteFinal(int anno, string beca, string periodo)
        {
                
            ReporteService con = new ReporteService();
                return Ok(con.GetReporteFinalxTipoBeca(anno, periodo, beca));

        }
        [HttpGet]
        [Route("GetReporteFinalGeneral")]
        public IHttpActionResult GetReporteFinalGeneral(int anno, string periodo)
        {

            ReporteService con = new ReporteService();
            return Ok(con.GetReporteFinalGeneral(anno, periodo));
        }
        [HttpGet]
        [Route("GetHistoricoProfesor")]
        public IHttpActionResult GetHistoricoProfesor(string cedula)
        {

            ReporteService con = new ReporteService();
            return Ok(con.GetReporteProfesor(cedula));
        }
        [HttpGet]
        [Route("GetHistoricoEstudiante")]
        public IHttpActionResult GetHistoricoEstudiante(string carnet)
        {

            ReporteService con = new ReporteService();
            return Ok(con.GetReporteEstudiante(carnet));
        }
    }
    }









