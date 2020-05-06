﻿using FormulaOneDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FormulaOneWebAPIProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("/api/circuits")]
    public class CircuitsController : ApiController
    {
        DbTools db = new DbTools();

        [Route("")]
        public IEnumerable<Circuit> GetAllCircuits()
        {
            return db.Circuits.Values;
        }

        [Route("{id:int}")]
        public IHttpActionResult GetCircuit(int id)
        {
            try
            {
                Circuit c = db.Circuits[id];
                return Ok(c);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
