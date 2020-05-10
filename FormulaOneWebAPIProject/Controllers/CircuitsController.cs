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
        public IEnumerable<CircuitItem> GetAllCircuits()
        {
            List<CircuitItem> c = new List<CircuitItem>();
            db.Circuits.Values.ToList().ForEach(circuit => c.Add(new CircuitItem(circuit)));
            return c;
        }

        [Route("{id:int}")]
        public Circuit GetCircuit(int id)
        {
            return db.Circuits[id];
        }

        [Route("count")]
        public int GetCircuitsCount()
        {
            return db.Circuits.Count;
        }
    }
}
