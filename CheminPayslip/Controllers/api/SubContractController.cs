using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CheminPayslip.Models;

namespace CheminPayslip.Controllers.api
{
    public class SubContractController : ApiController
    {
        private ApplicationDbContext _context;

        public SubContractController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: api/SubContract
        public IHttpActionResult Get(string query = null)
        {
            var employees = _context.SiteAdmin.ToList();
            if (!String.IsNullOrWhiteSpace(query))
                employees = employees.Where(c => c.PlaceName.ToLower().StartsWith(query)).ToList();

            return Ok(employees);
        }

        // GET: api/SubContract/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SubContract
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SubContract/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SubContract/5
        public void Delete(int id)
        {
        }
    }
}
