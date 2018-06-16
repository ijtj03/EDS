using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto1.Classes;
using Proyecto1.Controllers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace UnitTestProyecto1
{
    [TestClass]
    public class FormulariosControllerTest
    {
        Formulario formulario = new Formulario()
        {
            IdForm = 1,
            Carnet = "2015127287",
            Correo = "and-h@hotmail.com",
            Cedula = "116570101",
            CuentaBancaria = 1205152133,
            IdBeca = 1,
            IdCurso = 1,
            IdDep = 1,
            ImgCedula = "nohayimagen",
            ImgCuentaBancaria = "nohayimagen",
            ImgPromedioPonderadoAnterior = "nohayimagen",
            ImgPromedioPonderadoGeneral = "nohayimagen",
            OtraBeca = "TU",
            OtraBecaHoras = 50,
            PromedioCurso = 80,
            PromedioPonderadoAnterior = 99.99m,
            PromedioPonderadoGen = 99.99m,
            Tel = "85854546",
            Periodo = "II"
        };

        [TestMethod]
        public void GuardarForm()
        {
            
            FormulariosController formulariosController =new FormulariosController();
            IHttpActionResult resultado = formulariosController.GuardarForm(formulario);
            Assert.IsInstanceOfType(resultado,typeof(OkResult));

        }
        [TestMethod]
        public void GetAllForms()
        {
            FormulariosController formulariosController = new FormulariosController();
            IHttpActionResult resultado = formulariosController.GetAllForms();
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Formulario>>));
        }
        [TestMethod]
        public void GetFormulariosGuardados()
        {
            FormulariosController formulariosController = new FormulariosController();
            IHttpActionResult resultado = formulariosController.GetFormulariosGuardados(1);
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Formulario>>));
        }
        [TestMethod]
        public void ActualizarFormularioGuardado()
        {
            FormulariosController formulariosController = new FormulariosController();
            IHttpActionResult resultado = formulariosController.ActualizarFormularioGuardado(formulario);
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<int>));
        }
        [TestMethod]
        public void EnviarForm()
        {
            FormulariosController formulariosController = new FormulariosController();
            IHttpActionResult resultado = formulariosController.EnviarForm(2,2015127287,"II");
            Assert.IsInstanceOfType(resultado, typeof(OkResult));
        }
        [TestMethod]
        public void ActualizarFormularioEnviado()
        {
            FormulariosController formulariosController = new FormulariosController();
            IHttpActionResult resultado = formulariosController.ActualizarFormularioEnviado(formulario);
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<int>));
        }
        [TestMethod]
        public void GuardarEnviarForm()
        {
            FormulariosController formulariosController = new FormulariosController();
            IHttpActionResult resultado = formulariosController.GuardarEnviarForm(formulario);
            Assert.IsInstanceOfType(resultado, typeof(OkResult));

        }
    }
}
