using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto1.Controllers;
using Proyecto1.Classes;
using System.Web.Http;
using System.Web.Http.Results;
using System.Collections.Generic;

namespace UnitTestProyecto1
{
    [TestClass]
    public class VariosControllerTest
    {
        [TestMethod]
        public void GetAllDeps()
        {

            VariosController variosController = new VariosController();
            IHttpActionResult resultado = variosController.GetAllDeps();

            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Departamento>>));

        }
        [TestMethod]
        public void GetAllCursos()
        {

            VariosController variosController = new VariosController();
            IHttpActionResult resultado = variosController.GetAllCursos();

            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Departamento>>));

        }
    }
    
    
}
