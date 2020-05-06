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
    [RoutePrefix("/api/countries")]
    public class CountriesController : ApiController
    {
        DbTools db = new DbTools();
    
        [Route("")]
        public IEnumerable<Country> GetAllCountries()
        {
            return db.Countries.Values;
        }

        [Route("{id:string}")]
        public IHttpActionResult GetCountry(string id)
        {
            try
            {
                Country c = db.Countries[id.ToUpper()];
                return Ok(c);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
