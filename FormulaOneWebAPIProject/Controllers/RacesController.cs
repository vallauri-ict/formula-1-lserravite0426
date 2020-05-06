using FormulaOneDll;
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
    [RoutePrefix("/api/races")]
    public class RacesController : ApiController
    {
        DbTools db = new DbTools();

        [Route("")]
        public IEnumerable<Race> GetAllRaces()
        {
            return db.Races.Values;
        }

        [Route("{id:int}")]
        public IHttpActionResult GetRace(int id)
        {
            try
            {
                Race r = db.Races[id];
                return Ok(r);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
