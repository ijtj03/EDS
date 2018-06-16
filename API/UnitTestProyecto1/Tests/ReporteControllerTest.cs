using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Proyecto1.Classes;
using Proyecto1.Controllers;
using System.Web.Http;
using System.Web.Http.Results;

namespace UnitTestProyecto1
{
    [TestClass]
    public class ReporteControllerTest
    {
        [TestMethod]
        public void GetReporteInicial()
        {
            ReporteController reporteController = new ReporteController();
            IHttpActionResult resultado = reporteController.GetReporteInicial(2018,1,"II") ;
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Reporte>>));
        }
        [TestMethod]
        public void GetReporteInicialGeneral()
        {
            ReporteController reporteController = new ReporteController();
            IHttpActionResult resultado = reporteController.GetReporteInicialGeneral(2018,"II");
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Reporte>>));
        }
        [TestMethod]
        public void GetReporteFinal()
        {
            ReporteController reporteController = new ReporteController();
            IHttpActionResult resultado = reporteController.GetReporteFinal(2018, 1, "II");
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Reporte>>));
        }
        [TestMethod]
        public void GetReporteFinalGeneral()
        {
            ReporteController reporteController = new ReporteController();
            IHttpActionResult resultado = reporteController.GetReporteFinalGeneral(2018,"II");
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Reporte>>));
        }
        [TestMethod]
        public void GetHistoricoProfesor()
        {
            ReporteController reporteController = new ReporteController();
            IHttpActionResult resultado = reporteController.GetHistoricoProfesor("999999999");
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Reporte>>));
        }
        [TestMethod]
        public void GetHistoricoEstudiante()
        {
            ReporteController reporteController = new ReporteController();
            IHttpActionResult resultado = reporteController.GetHistoricoEstudiante("2015127287");
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Reporte>>));
        }
    }
}
