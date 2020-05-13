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
    [RoutePrefix("api/races")]
    public class RacesController : ApiController
    {
        DbTools db = new DbTools();

        [Route("list")]
        public IEnumerable<RaceItem> GetAllRaces()
        {
            List<RaceItem> r = new List<RaceItem>();
            db.Races.Values.ToList().ForEach(race => r.Add(new RaceItem(race)));
            return r;
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
