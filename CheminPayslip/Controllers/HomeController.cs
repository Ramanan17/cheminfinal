
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using CheminPayslip.Models;
using Remotion.Data.Linq.Clauses;

namespace CheminPayslip.Controllers
{
    public class HomeController : Controller
    {
        // GET: ExcelDemo
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();

        }

        public ActionResult Site()
        {
            var site=new SiteViewModel()
            {
               
                ErrorMessage = "",
                isValid = false,
                EmployeeEsi = 1.75,
                EmployerEsi = 4.75

            };
            return View(site);
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult TableValid()
        {
            var table1 = _context.TableValid.SingleOrDefault(m => m.Id == 1);
            var table2 = _context.TableValid.SingleOrDefault(m => m.Id == 2);
            var table3 = _context.TableValid.SingleOrDefault(m => m.Id == 3);
            var tablevalid = new TableCheckViewModel()
            {
                IsTable1Valid = table1.IsValid,
                IsTable2Valid = table2.IsValid,
                IsTable3Valid = table3.IsValid,
                Message = "",
                processValid = false
            };

            return View("TableValid", tablevalid);
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult CheckTableValid(TableCheckViewModel tablevalid)
        {
            var table1 = _context.TableValid.SingleOrDefault(m => m.Id == 1);
            var table2 = _context.TableValid.SingleOrDefault(m => m.Id == 2);
            var table3 = _context.TableValid.SingleOrDefault(m => m.Id == 3);
            if (table1 == null || table2 ==null || table3==null)
            {
                tablevalid.processValid = false;
                tablevalid.Message = "Process failed.Please Try Again";
                return View("TableValid", tablevalid);

            }

            table1.IsValid = tablevalid.IsTable1Valid;
            table2.IsValid = tablevalid
                .IsTable2Valid;
            table3.IsValid = tablevalid.IsTable3Valid;
            tablevalid.processValid = true;
            _context.SaveChanges();
            tablevalid.Message = "Successfull";
            return View("TableValid", tablevalid);
        }

        [System.Web.Http.HttpPost]
        public ActionResult AddSiteResult(SiteViewModel site)
        {
            var employee = _context.Employess.SingleOrDefault(m => m.Name == site.EmployeeName);
            var check = _context.SiteAdmin.Any(s => s.Placeid == site.PlaceId);
            if (employee == null )
            {
                site.ErrorMessage =
                    "Please enter the employee name in lowercase and select the name from given dropdown";
                site.isValid = false;
                return View("Site", site);

            }

            if (check)
            {
                site.ErrorMessage =
                    "Please Provide an unique Place Id";
                site.isValid = false;
                return View("Site", site);
            }
            var newSite = new Site()
            {
                EmployeeId = employee.EmployeeId,
                Password = site.PassWord,
                Placeid = site.PlaceId,
                PlaceName = site.PlaceName
            };

            _context.SiteAdmin.Add(newSite);
            _context.SaveChanges();
            return RedirectToAction("Index","Site");
            
        }
      [System.Web.Mvc.HttpPost]
        public JsonResult GetEmployees(string prefix)
        {
            var employee = _context.Employess.Where(x => x.Name.ToLower().StartsWith(prefix));
            return new JsonResult {Data = employee, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        public ActionResult Add()
        {
            var emp = new ValidateLogin()
            {
                EmployeeID = 0,
                Password = "",
                Valid = true,
                ErrorMessage = "Please enter the  Employee Details"
            };
            return View("CreateUser",emp);
        }
       
        public ActionResult Manage()
        {

           
            return View("ManageAdmin");
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult AddUser(ValidateLogin login)
        {
            var check = _context.MyLogins.SingleOrDefault(m => m.EmployeeDetailsId == login.EmployeeID);
            if (check != null)
            {
                login.Valid = false;
                login.ErrorMessage = "Employee Id already Exists";
                return View("CreateUser", login);
            }
            
           var emp = new myLogin()
           {
               EmployeeDetailsId = login.EmployeeID,
               Password =login.Password

           };
            login.Valid = true;
            

            _context.MyLogins.Add(emp);
            _context.SaveChanges();
            login.ErrorMessage = "User Created Successfully with id = " + login.EmployeeID + " Password = " + login.Password;
            return View("CreateUser", login);
        }

        public ActionResult Reset()
        {
            var login=new ValidateLogin()
            {
                Valid = true,
                ErrorMessage = ""
            };
            return View("ResetPassword",login);
        }
        public ActionResult Index()
        {
            var login = new ValidateLogin()
            {
                EmployeeID = 0,
                Valid = true
               
            };
            return View(login);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult ChangePassword(ValidateLogin login)
        {

            var emp = _context.MyLogins.SingleOrDefault(m => m.EmployeeDetailsId == login.EmployeeID);
            if (emp == null)
            {
                login.Valid = false;
                login.ErrorMessage = "EmployeeId Does not Exist";
                return View("ManageAdmin", login);
            }

            if (emp != null)
            {
                emp.Password = login.Password;
                _context.SaveChanges();
                return RedirectToAction("Index", "Login");
            }

            return View("ManageAdmin",login);

        }
    }
}