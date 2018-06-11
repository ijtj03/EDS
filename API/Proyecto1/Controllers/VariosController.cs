﻿using Proyecto1.Classes;
using Proyecto1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proyecto1.Controllers
{
    [RoutePrefix("api/Varios")]
    public class VariosController : ApiController
    {
        [HttpGet]
        [Route("GetAllDeps")]
        public IHttpActionResult GetAllDeps()
        {
            VariosService con = new VariosService();
            return Ok(con.GetAllDeps());
        }
        [HttpGet]
        [Route("GetAllCursos")]
        public IHttpActionResult GetAllCursos()
        {
            VariosService con = new VariosService();
            return Ok(con.GetAllCursos());
        }
    }
}