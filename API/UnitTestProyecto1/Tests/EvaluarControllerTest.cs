using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto1.Controllers;
using Proyecto1.Classes;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace UnitTestProyecto1
{
    [TestClass]
    public class EvaluarControllerTest
    {
        [TestMethod]
        public void GetEstudiantesxUsuario()
        {
            EvaluarController evaluarController = new EvaluarController();
            IHttpActionResult resultado = evaluarController.GetEstudiantesxUsuario(1);

            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Evaluacion>>));
        }
        [TestMethod]
        public void GuardarEvaluacion()
        {
            Evaluacion evaluacion = new Evaluacion
            {
                IdEvaluacion = 2,
                Observaciones = "Realizo satisfactoriamente el trabajo",
                Recomienda = 0,
                HorasLaboradas = 50
            };
            EvaluarController evaluarController = new EvaluarController();
            IHttpActionResult resultado = evaluarController.GetEstudiantesxUsuario(1);

            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Evaluacion>>));
        }
        [TestMethod]
        public void GetAllEvaluaciones()
        {
            EvaluarController evaluarController = new EvaluarController();
            IHttpActionResult resultado = evaluarController.GetAllEvaluaciones();

            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Evaluacion>>));
        }
    }
}
