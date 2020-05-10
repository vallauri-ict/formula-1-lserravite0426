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
    [RoutePrefix("api/teams")]
    public class TeamsController : ApiController
    {
        DbTools db = new DbTools();

        [Route("list")]
        public IEnumerable<TeamItem> GetAllTeams()
        {
            List<TeamItem> t = new List<TeamItem>();
            db.Teams.ForEach(team => t.Add(new TeamItem(team)));
            return t;
        }

        [Route("{id:int}/details")]
        public Team GetTeam(int id)
        {
            return db.Teams.Find(team => team.ID == id);
        }

        [Route("count")]
        public int GetTeamsCount()
        {
            return db.Teams.Count;
        }
    }
}
