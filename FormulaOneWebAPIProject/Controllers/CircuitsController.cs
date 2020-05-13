using FormulaOneDll;
using FormulaOneWebAPIProject.DTOs;
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
    [RoutePrefix("api/circuits")]
    public class CircuitsController : ApiController
    {
        DbTools db = new DbTools();

        [Route("list")]
        public IEnumerable<Circuit> GetAllCircuits()
        {
            return db.Circuits.Values;
        }

        [Route("count")]
        public int GetCircuitsCount()
        {
            return db.Circuits.Count;
        }
    }
}
