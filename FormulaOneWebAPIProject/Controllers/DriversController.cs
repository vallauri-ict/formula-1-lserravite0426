using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using FormulaOneDll;
using FormulaOneWebAPIProject.DTOs;

namespace FormulaOneWebAPIProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/drivers")]
    public class DriversController : ApiController
    {
        DbTools db = new DbTools();

        [Route("list")]
        public IEnumerable<DriverItem> GetAllDrivers()
        {
            List<DriverItem> d = new List<DriverItem>();
            db.Drivers.Values.ToList().ForEach(driver => d.Add(new DriverItem(driver)));
            return d;
        }

        [Route("{id:int}/details")]
        public Driver GetDriver(int id)
        {
            return db.Drivers[id];
        }

        [Route("count")]
        public int GetDriversCount()
        {
            return db.Drivers.Count;
        }
    }
}
