﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FormulaOneDll;

namespace FormulaOneWebAPIProject.Controllers
{
    public class DriversController : ApiController
    {
        DbTools db = new DbTools();

        public IEnumerable<Driver> GetAllDrivers()
        {
            return db.Drivers.Values;
        }
    }
}
