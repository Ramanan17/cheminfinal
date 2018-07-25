using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheminPayslip.Models;

namespace CheminPayslip.Controllers
{
    public class ResetPasswordController : Controller
    {
        // GET: ResetPassword
        private ApplicationDbContext _context;

        public ResetPasswordController()
        {
            _context=new ApplicationDbContext();
        }
        public ActionResult ViewthePage()
        {
            return View("ResetPage");
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        [HttpPost]
        public ActionResult Reset(ResetPassword reset)
        {
            var employee = _context.MyLogins.SingleOrDefault(c => c.EmployeeDetailsId == reset.EmployeeId);
            if (employee == null)
            {
                return HttpNotFound();
            }
            if (employee.Password != reset.OldPassword)
            {
                ViewBag.Message = "Password Entered is Wrong";
                return View("ResetPage");
            }
            if (reset.Password != reset.ConfirmPassword)
            {
                ViewBag.Message = "Password Does not match";
                return View("ResetPage");
            }

            employee.Password = reset.ConfirmPassword;
            _context.SaveChanges();
           // _context.Database.ExecuteSqlCommand("Update myLogins set Password = "+reset.Password+"where EmployeeDetailsId = "+reset.EmployeeId);
         
            return RedirectToAction("Index","Login");
        }

        
    }
}