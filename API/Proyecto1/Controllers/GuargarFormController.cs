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
    [RoutePrefix("api/Formularios")]
    public class GuargarFormController
    {
        [HttpPost]
        [Route("GuardarForm")]
        public void PostSucursal([FromBody] Formulario empresa)
        {
            GuardarFormService con = new GuardarFormService();
            con.GuardarForm(empresa);
        }
        /*[HttpGet]
        [Route("Get")]
        public IHttpActionResult GetUser(int id)
        {
            GuardarFormService con = new GuardarFormService();
            return Ok(con.GetUser(id));
        }*/
    }
}