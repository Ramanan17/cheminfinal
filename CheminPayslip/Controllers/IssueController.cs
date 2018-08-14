using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheminPayslip.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CheminPayslip.Controllers
{
    public class IssueController : Controller
    {
        private ApplicationDbContext _context;


        public IssueController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Issue
        public ActionResult InitPage(int id,int subid,int old)
        {
            var issueList = new List<issueMoel>();
            var issueList1 = new List<issueMoel>();
            if (subid != 0)
            {
                dynamic emp;
                if (old == 0)
                {
                     emp= _context.Master4.Where(m => m.SUBID == subid);
                }
                else
                {
                    emp = _context.Master.Where(m => m.SUBID == subid);
                }
               
               
                foreach (var e in emp)
                {
                    bool i = true;
                    if (e.issued == null)
                    {
                        i = false;
                    }
                    else
                    {
                        i = (bool)e.issued;
                    }

                    var issue = new issueMoel()
                    {
                        EmpId = e.EmpId,
                        EmpName = e.name,
                        issue = i,
                        issueDate = e.issueDate,
                        placeid = id,
                        SUBID = subid
                    };
                    issueList.Add(issue);
                }
            }
            else
            {
                dynamic emp;
                if (old == 0)
                {
                    emp = _context.Master4.Where(m => m.placeid == id.ToString() && m.SUBID == 0);

                }
                else
                {
                    emp = _context.Master.Where(m => m.placeid == id.ToString() && m.SUBID == 0);

                }
                //  var issueList = new List<issueMoel>();
                foreach (var e in emp)
                {
                    bool i  = true;
                    if (e.issued == null)
                    {
                        i = false;
                    }
                    else
                    {
                        i = (bool) e.issued;
                    }
                    var issue = new issueMoel()
                    {
                        EmpId = e.EmpId,
                        EmpName = e.name,
                        issue = i,
                        issueDate = e.issueDate,
                        placeid = id,
                        SUBID = subid
                    };
                    issueList.Add(issue);
                }

            }

            if (old == 0)
            {
                return View("InitPageOld",issueList);
            }
            else
            {
                return View(issueList);
            }
            

        }

        [HttpPost]
        public ActionResult Submit(List<issueMoel> issue,int old)
        {
            foreach (var iss in issue)
            {
                dynamic employee;
                if (old == 0)
                {
                    employee = _context.Master4.FirstOrDefault(m => m.EmpId == iss.EmpId);

                }
                else
                {
                    employee = _context.Master.SingleOrDefault(m => m.EmpId == iss.EmpId);

                }
                if (employee == null)
                {
                    return HttpNotFound();
                }

                employee.issued = iss.issue;
                employee.issueDate = iss.issueDate;
                _context.SaveChanges();
            }

            return RedirectToAction("ViewSites", "Admin");
        }
    }
}