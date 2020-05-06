using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using FormulaOneDll;

namespace FormulaOneWebAPIProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("/api/teams")]
    public class TeamsController : ApiController
    {
        DbTools db = new DbTools();

        [Route("")]
        public IEnumerable<Team> GetAllTeams()
        {
            return db.Teams;
        }

        [Route("{id:int}")]
        public IHttpActionResult GetTeams(int id)
        {
            Team t = db.Teams.Find(team => team.ID == id);
            if (t != null)
                return Ok(t);
            else
                return NotFound();
        }
    }
}
