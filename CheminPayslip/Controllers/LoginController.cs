using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheminPayslip.Models;

namespace CheminPayslip.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        // GET: Login
        private ApplicationDbContext _context;

        public LoginController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult ResetPassword()
        {
            return RedirectToAction("ViewthePage","ResetPassword");
        }
        public ActionResult Index()
        {

            var validinfo = new ValidateLogin()
            {
                Valid = true,
                ErrorMessage = "",
                Month = new[]
                {

                    new SelectListItem { Value = "1", Text = DateTime.Now.AddMonths(-1).ToString("MMMM")},
                    new SelectListItem { Value = "2", Text = DateTime.Now.AddMonths(-2).ToString("MMMM") },
                    new SelectListItem { Value = "3", Text = DateTime.Now.AddMonths(-3).ToString("MMMM") },
                   
                }




            };
            return View(validinfo);

        }

        [HttpPost]
        public ActionResult Save(ValidateLogin logininfo)
        {
            if (!ModelState.IsValid)
            {
                var validinfo = new ValidateLogin()
                {
                    Valid = false,
                    ErrorMessage = "Please Enter proper Credentials",
                    Month = new[]
                    {

                        new SelectListItem { Value = "1", Text = DateTime.Now.AddMonths(-1).ToString("MMMM")},
                        new SelectListItem { Value = "2", Text = DateTime.Now.AddMonths(-2).ToString("MMMM") },
                        new SelectListItem { Value = "3", Text = DateTime.Now.AddMonths(-3).ToString("MMMM") },

                    },
                    MonthVal = logininfo.MonthVal

                };
                return View("Index", validinfo);
            }
           

           
            var myLogin = _context.MyLogins.SingleOrDefault(c => c.EmployeeDetailsId == logininfo.EmployeeID);

            if (myLogin == null)
            {
                var validinfo = new ValidateLogin()
                {
                    Valid = false,
                    ErrorMessage = "The Employee Id does not exist",

                    Month = new[]
                    {

                        new SelectListItem { Value = "1", Text = DateTime.Now.AddMonths(-1).ToString("MMMM")},
                        new SelectListItem { Value = "2", Text = DateTime.Now.AddMonths(-2).ToString("MMMM") },
                        new SelectListItem { Value = "3", Text = DateTime.Now.AddMonths(-3).ToString("MMMM") },

                    },
                    MonthVal = logininfo.MonthVal

                };
                return View("Index", validinfo);
            }

            if (logininfo.Password != myLogin.Password)
            {
                var validinfo = new ValidateLogin()
                {
                    Valid = false,
                    ErrorMessage = "The UserName or Password does not match",
               
                    Month = new[]
                    {

                        new SelectListItem { Value = "1", Text = DateTime.Now.AddMonths(-1).ToString("MMMM")},
                        new SelectListItem { Value = "2", Text = DateTime.Now.AddMonths(-2).ToString("MMMM") },
                        new SelectListItem { Value = "3", Text = DateTime.Now.AddMonths(-3).ToString("MMMM") },

                    },
                    MonthVal = logininfo.MonthVal

                };
                return View("Index", validinfo);

            }

            if (logininfo.MonthVal == 1)

            {
                var employee = _context.Employess.SingleOrDefault(c => c.EmployeeId == logininfo.EmployeeID);
                var tablevalid = _context.TableValid.SingleOrDefault(c => c.Id == 1);

                if (!tablevalid.IsValid)
                {
                    var validinfo = new ValidateLogin()
                    {
                        Valid = false,
                        ErrorMessage = "Table has been not updated for the Month.Please Contact Administrator for details",

                        Month = new[]
                        {

                            new SelectListItem { Value = "1", Text = DateTime.Now.AddMonths(-1).ToString("MMMM")},
                            new SelectListItem { Value = "2", Text = DateTime.Now.AddMonths(-2).ToString("MMMM") },
                            new SelectListItem { Value = "3", Text = DateTime.Now.AddMonths(-3).ToString("MMMM") },

                        },
                        MonthVal = logininfo.MonthVal

                    };
                    return View("Index", validinfo);

                }
                if (employee == null)
                {
                    var validinfo = new ValidateLogin()
                    {
                        Valid = false,
                        ErrorMessage = "User does not exist",

                        Month = new[]
                        {

                            new SelectListItem { Value = "1", Text = DateTime.Now.AddMonths(-1).ToString("MMMM")},
                            new SelectListItem { Value = "2", Text = DateTime.Now.AddMonths(-2).ToString("MMMM") },
                            new SelectListItem { Value = "3", Text = DateTime.Now.AddMonths(-3).ToString("MMMM") },

                        },
                        MonthVal = logininfo.MonthVal

                    };
                    return View("Index", validinfo);

                }
                return View("Sucess", employee);
            }

            if (logininfo.MonthVal == 2)
            {
                var employee = _context.Employee2.SingleOrDefault(c => c.EmployeeId == logininfo.EmployeeID);
                var tablevalid = _context.TableValid.SingleOrDefault(c => c.Id == 2);
                if (!tablevalid.IsValid)
                {
                    var validinfo = new ValidateLogin()
                    {
                        Valid = false,
                        ErrorMessage = "Table has been not updated for the Selected Month.Please Contact Administrator for details",

                        Month = new[]
                        {

                            new SelectListItem { Value = "1", Text = DateTime.Now.AddMonths(-1).ToString("MMMM")},
                            new SelectListItem { Value = "2", Text = DateTime.Now.AddMonths(-2).ToString("MMMM") },
                            new SelectListItem { Value = "3", Text = DateTime.Now.AddMonths(-3).ToString("MMMM") },

                        },
                        MonthVal = logininfo.MonthVal

                    };
                    return View("Index", validinfo);

                }
                if (employee == null)
                {
                   
                   // if (employee == null)
                    {
                        var validinfo = new ValidateLogin()
                        {
                            Valid = false,
                            ErrorMessage = "User does not exist",

                            Month = new[]
                            {

                            new SelectListItem { Value = "1", Text = DateTime.Now.AddMonths(-1).ToString("MMMM")},
                            new SelectListItem { Value = "2", Text = DateTime.Now.AddMonths(-2).ToString("MMMM") },
                            new SelectListItem { Value = "3", Text = DateTime.Now.AddMonths(-3).ToString("MMMM") },

                        },
                            MonthVal = logininfo.MonthVal

                        };
                        return View("Index", validinfo);

                    }
                }
                return View("Success2", employee);
            }

            if (logininfo.MonthVal == 3)
            {
                var employee = _context.Employee3.SingleOrDefault(c => c.EmployeeId == logininfo.EmployeeID);
                var tablevalid = _context.TableValid.SingleOrDefault(c => c.Id == 3);
                if (!tablevalid.IsValid)
                {
                    var validinfo = new ValidateLogin()
                    {
                        Valid = false,
                        ErrorMessage = "Table has been not updated for the Selected Month.Please Contact Administrator for details",

                        Month = new[]
                        {

                            new SelectListItem { Value = "1", Text = DateTime.Now.AddMonths(-1).ToString("MMMM")},
                            new SelectListItem { Value = "2", Text = DateTime.Now.AddMonths(-2).ToString("MMMM") },
                            new SelectListItem { Value = "3", Text = DateTime.Now.AddMonths(-3).ToString("MMMM") },

                        },
                        MonthVal = logininfo.MonthVal

                    };
                    return View("Index", validinfo);

                }
                if (employee == null)
                {
                    var validinfo = new ValidateLogin()
                    {
                        Valid = false,
                        ErrorMessage = "User does not exist",

                        Month = new[]
                        {

                            new SelectListItem { Value = "1", Text = DateTime.Now.AddMonths(-1).ToString("MMMM")},
                            new SelectListItem { Value = "2", Text = DateTime.Now.AddMonths(-2).ToString("MMMM") },
                            new SelectListItem { Value = "3", Text = DateTime.Now.AddMonths(-3).ToString("MMMM") },

                        },
                        MonthVal = logininfo.MonthVal

                    };
                    return View("Index", validinfo);

                }
                return View("Success3", employee);
            }
            var validinfo4 = new ValidateLogin()
            {
                Valid = false,
                ErrorMessage = "Please Choose a proper month",

                Month = new[]
                {

                    new SelectListItem { Value = "1", Text = DateTime.Now.AddMonths(-1).ToString("MMMM")},
                    new SelectListItem { Value = "2", Text = DateTime.Now.AddMonths(-2).ToString("MMMM") },
                    new SelectListItem { Value = "3", Text = DateTime.Now.AddMonths(-3).ToString("MMMM") },

                },
                MonthVal = logininfo.MonthVal

            };
            return View("Index", validinfo4);

        }

       
    }
}