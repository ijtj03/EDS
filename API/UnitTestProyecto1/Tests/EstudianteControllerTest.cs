using System;
using Proyecto1.Controllers;
using Proyecto1.Classes;
using Proyecto1.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;
using System.Collections.Generic;
using System.Web.Http.Results;

namespace UnitTestProyecto1
{
    [TestClass]
    public class EstudienteControllerTest
    {
        [TestMethod]
        public void GetAllSolicitudes_DeberiaObtenerTodasLasSolicitudes()
        {
            EstudianteController estudianteController = new EstudianteController();
            IHttpActionResult resultado = estudianteController.GetAllSolicitudes();
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Estudiante>>));
        }
    }
    
    
}
