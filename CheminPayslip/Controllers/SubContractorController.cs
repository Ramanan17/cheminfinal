using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheminPayslip.Models;

namespace CheminPayslip.Controllers
{
    public class SubContractorController : Controller
    {
        private ApplicationDbContext _context;

        public SubContractorController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Sit
        // GET: SubContractor
        public ActionResult Index()
        {
            var sub = _context.Sub.ToList();
            return View(sub);
        }

        public ActionResult AddSub()
        {
            var viewmodel = new SubcontractViewModel()
            {
                SubContractId = 0,
                ErrorMessage = "",
                Isvalid = true,
                PlaceName = "",
                SubContractorName = "",
               
            };
            return View("AddSub", viewmodel);
        }

        public ActionResult Delete(int id)
        {
            var sub = _context.Sub.SingleOrDefault(m => m.SubContractId == id);
            if (sub == null)
            {
                return HttpNotFound();
            }

            _context.Sub.Remove(sub);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edittemp(int id)
        {
            var sub = _context.Sub.SingleOrDefault(m => m.SubContractId == id);
           
            if (sub == null)
            {
                return HttpNotFound();
            }

            var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid == sub.PlaceId);
            var view  = new SubcontractViewModel()
            {
                ErrorMessage = "",
                Isvalid = true,
                PlaceName = place.PlaceName,
                SubContractId = sub.SubContractId,
                SubContractorName = sub.SubContractorName
            };
            return View("Edit", view);


        }

        [HttpPost]
        public ActionResult Edit(SubcontractViewModel model)
        {
            var sub = _context.Sub.SingleOrDefault(m => m.SubContractId == model.SubContractId);

            if (sub == null)
            {
                return HttpNotFound();
            }
            var place = _context.SiteAdmin.SingleOrDefault(m => m.PlaceName == model.PlaceName);
            if (place == null)
            {
                var viewmodel = new SubcontractViewModel()
                {
                    ErrorMessage = "Please Select a place name from Drop down",
                    Isvalid = false,
                    PlaceName = place.PlaceName,
                    SubContractId = sub.SubContractId,
                    SubContractorName = sub.SubContractorName
                };
                return View("AddSub", viewmodel);
            }

            sub.SubContractId = model.SubContractId;
            sub.SubContractorName = model.SubContractorName;
            sub.PlaceId = (int) place.Placeid;
            _context.SaveChanges();
            return RedirectToAction("Index");




        }
        [HttpPost]
        public ActionResult Save(SubcontractViewModel model)
        {
            
            var place = _context.SiteAdmin.SingleOrDefault(m => m.PlaceName == model.PlaceName);
            if (place == null)
            {
                var viewmodel = new SubcontractViewModel()
                {
                    SubContractId = 0,
                    ErrorMessage = "Please Select a place name from Drop down",
                    Isvalid = false,
                    PlaceName = "",
                    SubContractorName = "",

                };
                return View("AddSub", viewmodel);
            }
           
           var add = new SubContract()
           {
               PlaceId = (int)place.Placeid,
               SubContractId = model.SubContractId,
               SubContractorName = model.SubContractorName


           };
            _context.Sub.Add(add);
            _context.SaveChanges();
            return RedirectToAction("Index", "SubContractor");




        }
        
    }
}