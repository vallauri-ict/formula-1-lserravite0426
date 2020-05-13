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
    [RoutePrefix("api/racesScores")]
    public class RacesScoresController : ApiController
    {
        DbTools db = new DbTools();

        [Route("")]
        public IEnumerable<RaceScore> GetAllRacesScores()
        {
            List<RaceScore> scores = db.RacesScores.FindAll(s => s.Driver.ID == 1);
            return scores;
        }

        [Route("drivers/{id:int}")]
        public IEnumerable<RaceScoreDriver> GetRaceScoreDrivers(int id)
        {
            List<RaceScoreDriver> rs = new List<RaceScoreDriver>();
            db.RacesScores.FindAll(r => r.Driver.ID == id).ForEach(r => rs.Add(new RaceScoreDriver(r)));
            return rs;
        }

        [Route("races/{id:int}")]
        public IEnumerable<RaceScoreRace> GetRaceScoreRaces(int id)
        {
            List<RaceScoreRace> rs = new List<RaceScoreRace>();
            db.RacesScores.FindAll(r => r.Race.ID == id).ForEach(r => rs.Add(new RaceScoreRace(r)));
            rs = rs.OrderBy(r => r.pos).ToList();
            for (int i = 0; i < rs.Count; i++)
            {
                if (rs[i].pos == 0)
                {
                    RaceScoreRace r = rs[i];
                    rs.RemoveAt(i--);
                    rs.Add(r);
                }
                else
                    break;
            }
            return rs;
        }

        [Route("count")]
        public int GetRacesScoresCount()
        {
            return db.RacesScores.Count;
        }
    }
}
