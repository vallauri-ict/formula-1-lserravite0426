﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using FormulaOneDll;

namespace FormulaOneWebAPIProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DriversController : ApiController
    {
        DbTools db = new DbTools();

        public IEnumerable<Driver> GetAllDrivers()
        {
            return db.Drivers.Values;
        }

        public IHttpActionResult GetCircuit(int id)
        {
            try
            {
                Driver d = db.Drivers[id];
                return Ok(d);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
