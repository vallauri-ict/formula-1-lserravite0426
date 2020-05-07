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
    [RoutePrefix("/api/racesScores")]
    public class RacesScoresController : ApiController
    {
        DbTools db = new DbTools();

        [Route("")]
        public IEnumerable<RaceScore> GetAllRacesScores()
        {
            List<RaceScore> scores = db.RacesScores.FindAll(s => s.Driver.ID == 1);
            return scores;
        }
    }
}
