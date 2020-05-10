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
    [RoutePrefix("api/races")]
    public class RacesController : ApiController
    {
        DbTools db = new DbTools();

        [Route("list")]
        public IEnumerable<Race> GetAllRaces()
        {
            return db.Races.Values;
        }

        [Route("{id:int}")]
        public Race GetRace(int id)
        {
            return db.Races[id];
        }

        [Route("count")]
        public int GetRacesCount()
        {
            return db.Races.Count;
        }
    }
}
