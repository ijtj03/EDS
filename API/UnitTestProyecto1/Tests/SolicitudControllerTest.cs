using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto1.Classes;
using Proyecto1.Controllers;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace UnitTestProyecto1
{
    [TestClass]
    public class SolicitudControllerTest
    {
        [TestMethod]
        public void GetAllSolicitudes()
        {
            SolicitudController solicitudController = new SolicitudController();
            IHttpActionResult resultado = solicitudController.GetAllSolicitudes();
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Solicitud>>));
        }
        [TestMethod]
        public void GetSolicitudesRevision()
        {
            SolicitudController solicitudController = new SolicitudController();
            IHttpActionResult resultado = solicitudController.GetSolicitudesRevision(1);
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<RevisionSolicitud>>));
        }
        [TestMethod]
        public void GetAllCancelaciones()
        {
            SolicitudController solicitudController = new SolicitudController();
            IHttpActionResult resultado = solicitudController.GetAllCancelaciones(1);
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Cancelacion>>));
        }
        [TestMethod]
        public void GetAllAprobadasRechazadas()
        {
            SolicitudController solicitudController = new SolicitudController();
            IHttpActionResult resultado = solicitudController.GetAllAprobadasRechazadas(1);
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Requisitos>>));
        }
        [TestMethod]
        public void GetAllSolicitudesEstudiante(){
            SolicitudController solicitudController = new SolicitudController();
            IHttpActionResult resultado = solicitudController.GetAllSolicitudesEstudiante("2015183074");
            Assert.IsInstanceOfType(resultado, typeof(OkNegotiatedContentResult<List<Solicitud>>));
        }
        [TestMethod]
        public void CancelarSolicitudEstudiante()
        {
            SolicitudController solicitudController = new SolicitudController();
            IHttpActionResult resultado = solicitudController.CancelarSolicitudEstudiante(1);
            Assert.IsInstanceOfType(resultado, typeof(OkResult));
        }
        [TestMethod]
        public void CancelarSolicitudUsuario()
        {
            SolicitudController solicitudController = new SolicitudController();
            IHttpActionResult resultado = solicitudController.CancelarSolicitudUsuario(1);
            Assert.IsInstanceOfType(resultado, typeof(OkResult));
        }
        [TestMethod]
        public void AceptarSolicitud()
        {
            SolicitudController solicitudController = new SolicitudController();
            IHttpActionResult resultado = solicitudController.AceptarSolicitud(1,1,50);
            Assert.IsInstanceOfType(resultado, typeof(OkResult));
        }
        [TestMethod]
        public void ReplicarSolicitud()
        {
            SolicitudController solicitudController = new SolicitudController();
            IHttpActionResult resultado = solicitudController.ReplicarSolicitud(1);
            Assert.IsInstanceOfType(resultado, typeof(OkResult));
        }
        [TestMethod]
        public void EstadoNoCumple()
        {
            Observacion observacion = new Observacion()
            {
                Descripcion = "Cambiar datos, promedio inferior a 70",
                IdSolicitud = 1
            };
            SolicitudController solicitudController = new SolicitudController();
            IHttpActionResult resultado = solicitudController.EstadoNoCumple(observacion);
            Assert.IsInstanceOfType(resultado, typeof(OkResult));
        }
    }
}
