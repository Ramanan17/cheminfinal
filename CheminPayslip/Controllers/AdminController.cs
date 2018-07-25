using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using CheminPayslip.Models;

namespace CheminPayslip.Controllers
{
    public class AdminController : Controller
    {

        private ApplicationDbContext _context;

        public AdminController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Admin
        public ActionResult Index()
        {
            var validinfo = new ValidateLogin()
            {
                Valid = true,
                ErrorMessage = ""

            };
            return View(validinfo);
            
        }
        [HttpPost]
        public ActionResult Validate(ValidateLogin login)
        {
            if (login.Password!= "@admin123")
            {
                login.ErrorMessage = "Please provide right credentials";
                login.Valid = false;
                return View("Index", login);

            }

         return   RedirectToAction("Manage", "Home");

        }

        public ActionResult ViewSites()
        {
            var sub = _context.SiteAdmin.ToList();
            if (sub == null)
            {
                return HttpNotFound("Please Contact Admin");
            }

            return View("ManageSites", sub);
        }

        public ActionResult ShowEmployees(int id)
        {
            var emp = _context.Master.Where(m => m.placeid == id.ToString()).ToList();
            
            var view =  new AdminLocal()
            {
                Employeee = emp,
                placeid = id
            };
            return View("ViewEmployees", view);
        }
        public ActionResult EditempSite(int id)
        {
            var emp = _context.Master.SingleOrDefault(m => m.EmpId == id);
            if (emp == null)
            {
                return HttpNotFound("Please Contact Admin");
            }
            var subcontractlist = new List<SelectListItem>()
            {
                new SelectListItem{Text = "Direct",Value = "0"}
            };
            var sub = _context.Sub.Where(m => m.PlaceId.ToString() == emp.placeid).ToList();
            foreach (var s in sub)
            {
                var append = new SelectListItem { Text = s.SubContractorName, Value = s.SubContractId.ToString() };
                subcontractlist.Add(append);
            }



            var master = new MasterSiteViewModel()
            {
                EmpId = emp.EmpId,
                SubContractor = subcontractlist,
                name = emp.name,
                aadharno = emp.aadharno,
                address = emp.address,
                bankacno = emp.bankacno,
                BankName = emp.BankName,
                branch = emp.branch,
                Design = emp.Design,
                dob = Convert.ToDateTime(emp.dob),
                doj = Convert.ToDateTime(emp.doj),
                emailId = emp.emailId,
                pincode = emp.pincode,
                panno = emp.panno,
                pfuan = emp.pfuan,
                pfelig = emp.pfelig != null && (bool)emp.pfelig,
                ifsccode = emp.ifsccode,
                otpperhour = emp.otpperhour,
                perdaysalary = emp.perdaysalary,
                esicode = emp.esicode,
                esielig = emp.esielig != null && (bool)emp.esielig,
                state = emp.state,
                phoneno = emp.phoneno,
                fname = emp.fname,
                Placeid = Convert.ToInt32(emp.placeid)



            };

            return View("Edit", master);

        }


        [HttpPost]
        public ActionResult EditResult(MasterSiteViewModel emp)
        {


            if (!ModelState.IsValid)
            {
                var emp1 = _context.Master.SingleOrDefault(m => m.EmpId == emp.EmpId);
                if (emp1 == null)
                {
                    return HttpNotFound("Please Contact Admin");
                }
                var subcontractlist = new List<SelectListItem>()
                {
                    new SelectListItem{Text = "Direct",Value = "0"}
                };
                var sub = _context.Sub.Where(m => m.PlaceId == Convert.ToInt32(emp1.placeid)).ToList();
                foreach (var s in sub)
                {
                    var append = new SelectListItem { Text = s.SubContractorName, Value = s.SubContractId.ToString() };
                    subcontractlist.Add(append);
                }



                var master = new MasterSiteViewModel()
                {
                    SubContractor = subcontractlist,
                    name = emp1.name,
                    aadharno = emp1.aadharno,
                    address = emp1.address,
                    bankacno = emp1.bankacno,
                    BankName = emp1.BankName,
                    branch = emp1.branch,
                    Design = emp1.Design,
                    dob = Convert.ToDateTime(emp1.dob),
                    doj = Convert.ToDateTime(emp1.doj),
                    emailId = emp1.emailId,
                    pincode = emp1.pincode,
                    panno = emp1.panno,
                    pfuan = emp1.pfuan,
                    pfelig = emp1.pfelig != null && (bool)emp.pfelig,
                    ifsccode = emp1.ifsccode,
                    otpperhour = emp1.otpperhour,
                    perdaysalary = emp1.perdaysalary,
                    esicode = emp1.esicode,
                    esielig = emp1.esielig != null && (bool)emp.esielig,
                    state = emp1.state,
                    phoneno = emp1.phoneno,
                    fname = emp1.fname,
                    Placeid = Convert.ToInt32(emp1.placeid),
                    SubId = Convert.ToInt32(emp1.SUBID)



                };

                return View("Edit", master);

            }
            var selected = _context.Master.SingleOrDefault(m => m.EmpId == emp.EmpId);
            if (selected == null)
            {
                return HttpNotFound("Please Contact Admin");
            }

            selected.SUBID = emp.SubId;
            selected.name = emp.name;
            selected.aadharno = emp.aadharno;
            selected.address = emp.address;
            selected.bankacno = emp.bankacno;
            selected.BankName = emp.BankName;
            selected.branch = emp.branch;
            selected.Design = emp.Design;
            selected.dob = emp.dob.ToShortDateString();
            selected.doj = emp.doj.ToShortDateString();
            selected.emailId = emp.emailId;
            selected.pincode = emp.pincode;
            selected.panno = emp.panno;
            selected.pfuan = emp.pfuan;
            selected.pfelig = emp.pfelig != null && (bool)emp.pfelig;
            selected.ifsccode = emp.ifsccode;
            selected.otpperhour = emp.otpperhour;
            selected.perdaysalary = emp.perdaysalary;
            selected.esicode = emp.esicode;
            selected.esielig = emp.esielig != null && (bool)emp.esielig;
            selected.state = emp.state;
            selected.phoneno = emp.phoneno;
            selected.fname = emp.fname;
            selected.placeid = emp.Placeid.ToString();
            _context.SaveChanges();
            

            return RedirectToAction("ShowEmployees", "Admin",new{id = selected.placeid});


        }
        public ActionResult DeleteResult(int id)
        {
            var selected = _context.Master.SingleOrDefault(m => m.EmpId == id);
            if (selected == null)
            {
                return HttpNotFound("Please Contact Admin");
            }
            _context.Master.Remove(selected);
            _context.SaveChanges();
            var total = _context.Master.Where(m => m.placeid == selected.placeid).ToList();
            return RedirectToAction("ShowEmployees","Admin",new {id =selected.placeid});
        }
        public ActionResult Addlocal(int id)
        {

            var subContracts = _context.Sub.Where(m => m.PlaceId == id).ToList();
            var listselectitem = new List<SelectListItem>();
            if (subContracts == null) ;
            {
                // listselectitem.Add(new SelectListItem{Value = "0",Text="Only Direct Employee No Subcontracators available"});
            }
            foreach (var sub in subContracts)
            {
                listselectitem.Add(new SelectListItem { Value = sub.SubContractId.ToString(), Text = sub.SubContractorName });
            }
            listselectitem.Add(new SelectListItem { Value = "0", Text = "Direct" });


            var master = new MasterSiteViewModel()
            {
                name = "",
                Design = "",
                SubContractor = listselectitem,
                esielig = true,
                pfelig = true,
                Placeid = id

            };
            foreach (var sub in subContracts)
            {
                master.SubContractor.Append(new SelectListItem { Value = sub.SubContractId.ToString(), Text = sub.SubContractorName.ToString() });

            }

            return View("AddlocalEmployee", master);

        }
        [HttpPost]
        public ActionResult AddEmployee(MasterSiteViewModel local)
        {
            var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid == local.Placeid);
            if (place == null)
            {
                return HttpNotFound("Please Contact Admin");
            }








            if (!ModelState.IsValid)
            {
                var subContracts = _context.Sub.Where(m => m.PlaceId == place.Placeid).ToList();
                var listselectitem = new List<SelectListItem>();
                if (subContracts == null) ;
                {
                    // listselectitem.Add(new SelectListItem{Value = "0",Text="Only Direct Employee No Subcontracators available"});
                }
                foreach (var sub in subContracts)
                {
                    listselectitem.Add(new SelectListItem { Value = sub.SubContractId.ToString(), Text = sub.SubContractorName });
                }
                listselectitem.Add(new SelectListItem { Value = "0", Text = "Direct" });


                var master = new MasterSiteViewModel()
                {
                    name = "",
                    Design = "",
                    SubContractor = listselectitem,
                    esielig = true,
                    pfelig = true,
                    Placeid = (int)place.Placeid

                };

                return View("AddlocalEmployee", master);


            }





            var max = _context.Master.OrderByDescending(m => m.Id).FirstOrDefault();
            if (max == null)
            {
                return HttpNotFound("Please Contact Admin Max");
            }
            int newId = max.EmpId + 1;

            var newEmployee = new MasterSite()
            {
                EmpId = newId,
                placeid = local.Placeid.ToString(),
                name = local.name,
                Design = local.Design,
                perdaysalary = local.perdaysalary,
                otpperhour = local.otpperhour,
                pfuan = local.pfuan,
                dob = local.dob.ToShortDateString(),
                fname = local.fname,
                bankacno = local.bankacno,
                BankName = local.BankName,
                esicode = local.esicode,
                ifsccode = local.ifsccode,
                address = local.address,
                state = local.state,
                pincode = local.pincode,
                phoneno = local.phoneno,
                emailId = local.emailId,
                aadharno = local.aadharno,
                panno = local.panno,
                doj = local.doj.ToShortDateString(),
                SUBID = local.SubId,
                pfelig = local.pfelig,
                esielig = local.esielig


            };
            _context.Master.Add(newEmployee);
            _context.SaveChanges();

            return RedirectToAction("ShowEmployees","Admin",new{id = local.Placeid});
        }

    }
}