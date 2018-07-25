using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheminPayslip.Models;

namespace CheminPayslip.Controllers
{
    public class CoordinatorController : Controller
    {
        private ApplicationDbContext _context;

        public CoordinatorController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: api/Site

        // GET: Coordinator
        public ActionResult Index()
        {
            var view = new CoordViewModel()
            {
                ErrorMessage = "",
                IsValid = true,
                Password = ""
            };
            
            return View("AddCoord",view);
        }

        [HttpPost]
        public ActionResult Login(CoordViewModel cord)
        {
            var place = _context.SiteAdmin.SingleOrDefault(m => m.CoordPassword == cord.Password);
            if (place == null)
            {
                var view = new CoordViewModel()
                {
                    ErrorMessage = "Enter a valid Password",
                    IsValid = false,
                    Password = ""
                };

                return View("AddCoord", view);

            }

            return RedirectToAction("SiteEdit", "SitePortal", new {id = place.Placeid, user = "coord"});

        }


    }
}