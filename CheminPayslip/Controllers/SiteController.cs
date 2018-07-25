using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheminPayslip.Models;

namespace CheminPayslip.Controllers
{
    public class SiteController : Controller
    {
        private ApplicationDbContext _context;

        public SiteController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Site
        public ActionResult Index()
        {
            var sitelist = _context.SiteAdmin.ToList();
            var siteview = new List<SiteViewModel>();
            

            foreach (var site in sitelist)
            {
                var employee = _context.Employee2.SingleOrDefault(m => m.EmployeeId == site.EmployeeId);
                if (employee == null)
                {
                   // break;
                }
                var view = new SiteViewModel()
                {
                    EmployeeName = employee.Name,
                    PlaceId = (int) site.Placeid,
                    PlaceName = site.PlaceName,
                    PassWord = site.Password,
                    CoordPassword = site.CoordPassword,
                    EmployeeEsi = site.EmployeeEsi,
                    EmployerEsi = site.EmployerEsi
                    


                };

                siteview.Add(view);
            
        }
            
            return View(siteview);
        }

        public ActionResult Edit(int id)
        {
            var site = _context.SiteAdmin.SingleOrDefault(m => m.Placeid == id);
            if (site == null)
            {
                return HttpNotFound();
            }
            var view = new SiteViewModel()
            {
                EmployeeName = ""
            };
            var employee = _context.Employess.SingleOrDefault(m => m.EmployeeId == site.EmployeeId);
           
            if (employee != null)
            {
                view.EmployeeName = employee.Name;
            }

            view.PlaceName = site.PlaceName;
            view.PassWord = site.Password;
            view.PlaceId = (int)site.Placeid;
            view.CoordPassword = site.CoordPassword;
            view.EmployeeEsi = site.EmployeeEsi;
            view.EmployerEsi = site.EmployerEsi;


            return View(view);
        }

        [HttpPost]
        public ActionResult ChangeDetails(SiteViewModel siteView)
        {
            var site = _context.SiteAdmin.SingleOrDefault(m => m.Placeid == siteView.PlaceId);
            if (site == null)
            {
                return HttpNotFound();

            }

            site.CoordPassword = siteView.CoordPassword;
            site.PlaceName = siteView.PlaceName;
            site.Password = siteView.PassWord;
            site.EmployeeEsi = siteView.EmployeeEsi;
            site.EmployerEsi = siteView.EmployerEsi;
            var employee = _context.Employess.SingleOrDefault(m => m.Name == siteView.EmployeeName);
            if (employee != null)
            {    site.EmployeeId = employee.EmployeeId;}

            _context.SaveChanges();

          return RedirectToAction("Index", "Site");

        }

        public ActionResult Delete(int id)
        {
            var site = _context.SiteAdmin.SingleOrDefault(m => m.Placeid == id);
            if (site == null)
            {
                return HttpNotFound();
            }
            _context.SiteAdmin.Remove(site);
            _context.SaveChanges();
            return RedirectToAction("Index", "Site");

        }
    }
}