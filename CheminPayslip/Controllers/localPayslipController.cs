using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheminPayslip.Models;

namespace CheminPayslip.Controllers
{
    public class localPayslipController : Controller
    {
        private ApplicationDbContext _context;

        public localPayslipController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: localPayslip
        public ActionResult Index()
        {
            var local = new locallogin()
            {
                EmpId = "",
                ErrorMessage = "",
                isValid = true
            };
            return View("Login",local);
        }
       
        [HttpPost]
        public ActionResult Result(locallogin login)
        {
            var subname = string.Empty;
            var emp = _context.Master.SingleOrDefault(m => m.EmpId.ToString() == login.EmpId);
            if (emp == null)
            {
                var local = new locallogin()
                {
                    EmpId = "",
                    ErrorMessage = "The given employee does not Exist",
                    isValid = false
                };
                return View("Login", local);
            }

            var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid.ToString() == emp.placeid);
            if (place == null)
            {
                var local = new locallogin()
                {
                    EmpId = "",
                    ErrorMessage = "There is some problem is proessing the request",
                    isValid = false
                };
                return View("Login", local);
            }

            var sub = _context.Sub.SingleOrDefault(m => m.SubContractId == emp.SUBID);
            if (sub == null)
            {
                subname = "Direct";
            }
            else
            {
                subname = sub.SubContractorName;
            }
            var result = new localpaymodel()
            {
                Master = emp,
                PlaeName = place.PlaceName,
                SubcontractorName = subname
            };
            return View("payslip", result);
        }
    }
}