using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CheminPayslip.Models;

namespace CheminPayslip.Controllers.api
{
    [RoutePrefix("api/Site")]
    public class SiteController : ApiController
    {

        private ApplicationDbContext _context;

        public SiteController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: api/Site
       
        
        public IHttpActionResult Get(string query = null)
        {
            var employees = _context.Employess.ToList();
            if (!String.IsNullOrWhiteSpace(query))
                employees=employees.Where(c => c.Name.ToLower().StartsWith(query)).ToList();

            return Ok(employees);
        }

        [Route("employeeDetails/{outid}")]
        [HttpGet]
        public IHttpActionResult GetEmployees(int outid)
        {
            dynamic employee;
            if (outid == 0)
            {
                employee = _context.Employee2.Where(m => m.Place != "PIC").ToList();

            }
            else
            {
                employee = _context.Employess.Where(m => m.Place != "PIC").ToList();

            }
            var emplist = new List<permlist>();
            int i = 1;
            foreach (var emp in employee)
            { 
                var list = new permlist()
                {
                    Id = i,
                    EmpId = emp.EmployeeId,
                    Designation = emp.DESIGNATION,
                    EmployeeName = emp.Name,
                    Grade = emp.gradeid.ToString(),
                    GrossWages = emp.CTC,
                    place = emp.cPlace

                };

                i++;
                emplist.Add(list);

            }
           
            return Ok(emplist);
        }

        [Route("employeelocal/{outid}")]
        [HttpGet]
        public IHttpActionResult GetLocal(int  outid)
        {
            int i = 1;
           
            if (outid == 0)
            {
                var local = _context.Master4.ToList();
                var lists = new List<locallist>();
                foreach (var loc in local)
                {
                    var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid.ToString() == loc.placeid);

                    var sub = _context.Sub.SingleOrDefault(m => m.SubContractId == loc.SUBID);
                    string name = string.Empty;
                    name = sub == null ? "Direct Employee" : sub.SubContractorName;
                    if (place != null && place.Placeid != 152)
                    {
                        var list = new locallist()
                        {
                            EmpId = loc.EmpId,
                            Id = i,
                            Designation = loc.Design,
                            EmployeeName = loc.name,
                            perday = loc.perdaysalary,
                            place = place.PlaceName,
                            SubContractor = name



                        };
                        i++;
                        lists.Add(list);
                    }
                }
                return Ok(lists);
            }
            else
            {
               var  local = _context.Master.ToList();
                var lists = new List<locallist>();
                foreach (var loc in local)
                {
                    var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid.ToString() == loc.placeid);

                    var sub = _context.Sub.SingleOrDefault(m => m.SubContractId == loc.SUBID);
                    string name = string.Empty;
                    name = sub == null ? "Direct Employee" : sub.SubContractorName;
                    if (place != null && place.Placeid != 152)
                    {
                        var list = new locallist()
                        {
                            EmpId = loc.EmpId,
                            Id = i,
                            Designation = loc.Design,
                            EmployeeName = loc.name,
                            perday = loc.perdaysalary,
                            place = place.PlaceName,
                            SubContractor = name



                        };
                        i++;
                        lists.Add(list);
                    }
                }
                return Ok(lists);

            }
          

           
        }

        [Route("Commit/{id}")]
        [HttpGet]
        public IHttpActionResult GetCommitment(int id)
        {
            dynamic commitment;
            if (id == 0)
            {
                commitment= _context.Commitment2.Where(m => m.EGross != 0 || m.LGross != 0).ToList();

            }
            else
            {
                commitment = _context.Commitment.Where(m => m.EGross != 0 || m.LGross != 0).ToList();

            }
            return Ok(commitment);
        }

        [Route("local/{id}/{outid}")]
        public IHttpActionResult GetLocal(int id,int outid)
        {
            dynamic employees;
            if (outid == 0)
            {
                employees = _context.Master4.Where(m => m.placeid == id.ToString()).ToList();

            }
            else
            {
                employees = _context.Master.Where(m => m.placeid == id.ToString()).ToList();


            }
            var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid == id);
            if (place == null)
            {
                return BadRequest();
            }
            var reports = new List<PermanentReport>();
            foreach (var employee in employees)
            {
              //  if (employee.total != 0)
                {
                    var report = new PermanentReport()
                    {
                        Design = employee.Design,
                        ESI = employee.esi,
                        LIC = employee.LIC,
                        PF = employee.pf,
                        Total = employee.grosswages,
                        name = employee.name,
                        NetWages = employee.netwages,
                        placename = place.PlaceName,
                        EmpId = employee.EmpId



                    };
                    reports.Add(report);

                }
            }
           
            return Ok(reports);
        }
        [Route("ILOUT/{id}/{outid}")]
        public IHttpActionResult GetLocalOUt(int id,int outid)
        {
            dynamic employees;
            if (outid == 0)
            {
                employees = _context.Master4.Where(m => m.placeid == id.ToString() && (m.issued == null || m.issued == false)).ToList();

            }
            else
            {
                employees = _context.Master.Where(m => m.placeid == id.ToString() && (m.issued == null || m.issued == false)).ToList();

            }
            var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid == id);
            if (place == null)
            {
                return BadRequest();
            }
            var reports = new List<PermanentReport>();
            foreach (var employee in employees)
            {
              //  if (employee.total != 0)
                {
                    var report = new PermanentReport()
                    {
                        Design = employee.Design,
                        ESI = employee.esi,
                        LIC = employee.LIC,
                        PF = employee.pf,
                        Total = employee.grosswages,
                        name = employee.name,
                        NetWages = employee.netwages,
                        placename = place.PlaceName,
                        EmpId = employee.EmpId,
                        advance = employee.advance



                    };
                    reports.Add(report);
                }
               
            }

            return Ok(reports);
        }


        [Route("report/{place}/{outid}")]
        [HttpGet]
        public IHttpActionResult GetPermanent(string place,int outid)
        {
            dynamic employees;
            if (outid == 0)
            {
                employees = _context.Employee2.Where(m => m.Place == place).ToList();

            }
            else
            {
                employees = _context.Employess.Where(m => m.Place == place).ToList();

            }
            var reports = new List<PermanentReport>();
            foreach (var employee in employees)
            {
               // if (employee.TOTAL != 0)
                {
                    var report = new PermanentReport()
                    {
                        Design = employee.DESIGNATION,
                        ESI = employee.ESI,
                        LIC = employee.LIC,
                        PF = employee.PF,
                        Total = employee.TOTAL,
                        name = employee.Name,
                        NetWages = employee.NETTOTAL,
                        grade = employee.GRADE,
                        EmpId = employee.EmployeeId,
                        placename = employee.Place



                    };
                    reports.Add(report);

                }
               
            }
           
            if (reports == null)
            {
                return BadRequest();
            }

            return Ok(reports);
        }
        [Route("Out/{place}/{outid}")]
        [HttpGet]
        public IHttpActionResult GetPermanentIssued(string place,int outid)
        {
            dynamic employees;
            if (outid == 0)
            {
                employees = _context.Employee2.Where(m => m.Place == place && (m.issued == (false || m.issued == null))).ToList();

            }
            else
            {
                employees = _context.Employess.Where(m => m.Place == place && (m.issued == (false || m.issued == null))).ToList();

            }
            var reports = new List<PermanentReport>();
            foreach (var employee in employees)
            {
              //  if (employee.TOTAL != 0)
                {
                    var report = new PermanentReport()
                    {
                        Design = employee.DESIGNATION,
                        ESI = employee.ESI,
                        LIC = employee.LIC,
                        PF = employee.PF,
                        Total = employee.TOTAL,
                        name = employee.Name,
                        NetWages = employee.NETTOTAL,
                        grade = employee.GRADE,
                        EmpId = employee.EmployeeId,
                        placename = employee.Place,
                        advance = employee.SALADV,
                        



                    };
                    reports.Add(report);
                }
                
            }

            if (reports == null)
            {
                return BadRequest();
            }

            return Ok(reports);
        }

        [Route("OutMaster/{outid}")]
        [HttpGet]
        public IHttpActionResult GetOutMaster(int outid)
        {
            dynamic employees;
            if (outid == 0)
            {
                 employees = _context.Master4.SingleOrDefault(m => m.EmpId == 14);

            }
            else
            {
                 employees = _context.Master.SingleOrDefault(m => m.EmpId == 14);

            }
            if (employees == null)
            {
                return BadRequest();
            }

            var date = Convert.ToDateTime(employees.date);

            return Ok(date.ToString("M"));
        }
        [Route("OutLocal/{outid}")]
        [HttpGet]
        public IHttpActionResult GetOutLocal(int outid)
        {
            dynamic employees;
            if (outid == 0)
            {

                employees = _context.Employee2.SingleOrDefault(m => m.EmployeeId == 106);
                
            }
            else
            {
                employees = _context.Employess.SingleOrDefault(m => m.EmployeeId == 106);

            }
            if (employees == null)
            {
                return BadRequest();
            }

           
            return Ok(employees.Date);
        }

        [Route("Sum")]
        [HttpGet]
        public IHttpActionResult GetSum()
        {
            var sum = _context.Commitment.Where(m => m.PLGross!=0).GroupBy(m => m.PlaceName).Select(g => new {LGross = g.Sum(i => i.LGross)});
            return Ok(sum);
        }
        

        [Route("master")]
        [HttpGet]
        public IHttpActionResult GetMaster()
        {
            var employees = _context.Master.ToList();
            

            return Ok(employees);
        }
        // GET: api/Site/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Site
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Site/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Site/5
        public void Delete(int id)
        {
        }
    }
}
