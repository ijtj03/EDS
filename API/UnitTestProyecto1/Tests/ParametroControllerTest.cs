using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Proyecto1.Classes;
using Proyecto1.Controllers;
using System.Web.Http;
using System.Web.Http.Results;

namespace UnitTestProyecto1
{
    [TestClass]
    public class ParametroControllerTest
    {
        [TestMethod]
        public void ActualizarParametro()
        {
            Parametro parametro = new Parametro()
            {
                FechaAjuste = "10/21/2018",
                FechaFinalCal = "10/21/2018",
                FechaFinalSol = "10/21/2018",
                FechaInicialCal = "10/21/2018",
                FechaInicialSol = "10/21/2018",
                HorasBecaAsEsp = 50,
                HorasBecaAsis = 50,
                HorasBecaEstudiante = 50,
                HorasBecaTotales = 150,
                HorasBecaTutoria = 50,
                IdParametro = 1

            };
            ParametroController parametroController = new ParametroController();
            IHttpActionResult resultado = parametroController.ActualizarParametro(parametro);
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<int>));

        }
        [TestMethod]
        public void GuardarParametros()
        {
            Parametro parametro = new Parametro()
            {
                FechaAjuste = "10/21/2018",
                FechaFinalCal = "10/21/2018",
                FechaFinalSol = "10/21/2018",
                FechaInicialCal = "10/21/2018",
                FechaInicialSol = "10/21/2018",
                HorasBecaAsEsp = 50,
                HorasBecaAsis = 50,
                HorasBecaEstudiante = 50,
                HorasBecaTotales = 150,
                HorasBecaTutoria = 50,
                IdParametro = 1

            };
            ParametroController parametroController = new ParametroController();
            IHttpActionResult resultado = parametroController.GuardarParametros(parametro);
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<int>));

        }
        [TestMethod]
        public void GetLast()
        {
            ParametroController parametroController = new ParametroController();
            IHttpActionResult resultado = parametroController.GetLast();
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<Parametro>));
        }
    }
}
