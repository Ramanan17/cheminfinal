using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using CheminPayslip.Models;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Ajax.Utilities;
using iTextSharp.tool.xml;
using iTextSharp.text.html.simpleparser;

namespace CheminPayslip.Controllers
{
    public class SitePortalController : Controller
    {
       

        private ApplicationDbContext _context;


        public SitePortalController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult SetEmployees()
        {
            var employee = _context.Employess.ToList();
            foreach (var emp in employee)
            {
                var log = _context.MyLogins.SingleOrDefault(m => m.EmployeeDetailsId == emp.EmployeeId);
                if (log == null)
                {
                    var my = new myLogin()
                    {
                        EmployeeDetailsId = emp.EmployeeId,
                        Password = "chem" + emp.EmployeeId

                    };
                }
            }

            return RedirectToAction("About", "Home");
        }

        public ActionResult Goback(string query)
        {
            if (query == "admin")
            {
                return RedirectToAction("ViewSites", "Admin");
            }
            var newLogin = new SiteValidLogin()
            {
                EmployeeId = 0,
                ErrorMessage = "",
                IsValid = true,
                Password = "",
                PlaceName = ""
            };
            return View("Index", newLogin);

        }

        public JsonResult ConverttoJson(MasterSite master)
        {
            return Json(master, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ProcessSalary()
        {
            var delete = _context.Commitment.SingleOrDefault(m => m.placeid == 157);
            if (delete != null)
            {
                _context.Commitment.Remove(delete);
            }
            
            var clear = _context.Commitment.ToList();
            foreach (var commit in clear)
            {
                commit.EESI = 0;
                commit.EPF = 0;
                commit.EEESI = 0;
                commit.EGross = 0;
                commit.ENet = 0;
                commit.ELIC = 0;
                commit.EEPF = 0;
                
                commit.LEESI = 0;
                commit.LEPF = 0;
               
                commit.LEESI = 0;
                commit.LGross = 0;
                commit.LNET = 0;
                commit.LLIC = 0;

                commit.PEESI = 0;
                commit.PEPF = 0;
                commit.PEEESI = 0;
                commit.PEGross = 0;
                commit.PENet = 0;
                commit.PELIC = 0;
                commit.PEEPF = 0;

                commit.PLEESI = 0;
                commit.PLEPF = 0;
                commit.PLEESI = 0;
                commit.PLGross = 0;
                commit.PLNET = 0;
                commit.PLLIC = 0;
                commit.PLEPF = 0;
                _context.SaveChanges();


            }
            var employees = _context.Master.ToList();
            foreach (var employee in employees)
            {
                double placeesi = 1.75;
                var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid.ToString() == employee.placeid);
                if (place == null)
                {
                    placeesi = 1.75;
                }
                else
                {
                    if (place.EmployeeEsi != null)
                    {
                        placeesi = (double)place.EmployeeEsi;
                    }
                   
                }
                if (employee.nod == null)
                {
                    employee.nod = 0;
                }

                if (employee.nodcoff == null)
                {
                    employee.nodcoff = 0;
                }

                if (employee.otpperhour == null)
                {
                    employee.otpperhour = 0;
                }

                if (employee.TEA == null)
                {
                    employee.TEA = 0;
                }

                if (employee.HouseRent == null)
                {
                    employee.HouseRent = 0;
                }

                if (employee.coggamt == null)
                {
                    employee.coggamt = 0;
                }

                if (employee.nodcoff == null)
                {
                    employee.nodcoff = 0;
                }

                if (employee.TEA == null)
                {
                    employee.TEA = 0;
                }

                if (employee.HouseRent == null)
                {
                    employee.HouseRent = 0;
                }

                if (employee.otherallow == null)
                {
                    employee.otherallow = 0;
                }

                if (employee.nohours == null)
                {
                    employee.nohours = 0;
                }

                if (employee.revocery == null)
                {
                    employee.revocery = 0;
                }

                if (employee.ptax == null)
                {
                    employee.ptax = 0;
                }

                if (employee.TDS == null)
                {
                    employee.TDS = 0;
                }

                if (employee.total == null)
                {
                    employee.total = 0;
                }

                if (employee.coggamt == null)
                {
                    employee.coggamt = 0;
                }

                if (employee.grosswages == null)
                {
                    employee.grosswages = 0;
                }

                if (employee.otamt == null)
                {
                    employee.otamt = 0;
                }

                if (employee.esielig == null)
                {
                    employee.esielig = false;
                }



                employee.total = employee.nod * employee.perdaysalary;
                employee.coggamt = employee.nodcoff * employee.perdaysalary;
                employee.otamt = employee.otpperhour * employee.nohours;
                employee.grosswages = ( (employee.total + employee.coggamt + employee.otamt + employee.TEA +
                                                                    employee.HouseRent + employee.otherallow));
                if (employee.grosswages != null)
                {
                    employee.grosswages = (float?) Math.Round((double) employee.grosswages);
                }
                if (employee.pfelig.GetValueOrDefault())
                {
                    if (employee.total == null)
                    {
                        employee.total = 0;
                        employee.pf = 0;
                    }
                    else
                    {
                        employee.pf = employee.total > 15000
                            ? 1800
                            : (float?) Math.Round((double) (employee.total * 0.12));
                    }
                }
                else
                {
                    employee.pf = 0;
                }
               
                if (employee.esielig.GetValueOrDefault())
                {
                    if (employee.grosswages == null)
                    {
                        employee.grosswages = 0;
                        employee.esi = 0;
                    }
                    else
                    {
                        employee.esi = (float?) Math.Round((double) (employee.grosswages * (placeesi/100)));
                    }
                }
                else
                {
                    employee.esi = 0;
                }

                if (employee.dedtot == null)
                {
                    employee.dedtot = 0;
                }

                if (employee.netwages == null)
                {
                    employee.netwages = 0;
                }

                if (employee.advance == null)
                {
                    employee.advance = 0;
                }

                employee.dedtot = (float?) Math.Round((double) (employee.pf + employee.advance + employee.revocery + employee.esi  +
                                                                (float?) employee.TDS + (float?) employee.ptax));
                employee.netwages =(float?) (  (employee.grosswages - employee.dedtot));
                if (employee.netwages != null)
                {
                    employee.netwages = (float?) Math.Round((double) employee.netwages);
                }

                   // Console.WriteLine("Credential file saved to: " + credPath);

                _context.SaveChanges();


            }

            var result2 = _context.Employess.Where(m =>  m.issued==false).GroupBy(m => m.Place).Select(g => new {total = g.Sum(i=> i.TOTAL),pf=g.Sum(i => i.PF),ESI=g.Sum(i=> i.ESI),lic=g.Sum(i=>i.LIC),net=g.Sum(i =>i.NETTOTAL),place=g.Key }).ToList();
            foreach (var enter in result2)
            {
                var commit = _context.Commitment.SingleOrDefault(m => m.PlaceName == enter.place);
                if (commit != null)
                {
                    commit.PEPF = Math.Round(enter.pf);
                    commit.PELIC = Math.Round(enter.lic);
                    commit.PEEPF = Math.Round(enter.pf);
                    commit.PEESI = Math.Round(enter.ESI);
                    commit.PEEESI = Math.Round(enter.ESI * (4.75 / 1.75));
                    commit.PEGross = Math.Round(enter.total);
                    commit.PENet = Math.Round(enter.net);

                    _context.SaveChanges();
                }
               
            }
            var result3= _context.Employess.GroupBy(m => m.Place).Select(g => new { total = g.Sum(i => i.TOTAL), pf = g.Sum(i => i.PF), ESI = g.Sum(i => i.ESI), lic = g.Sum(i => i.LIC), net = g.Sum(i => i.NETTOTAL), place = g.Key }).ToList();
            foreach (var enter in result3)
            {
                var commit = _context.Commitment.SingleOrDefault(m => m.PlaceName == enter.place);
                if (commit != null)
                {
                    commit.EPF = Math.Round(enter.pf);
                    commit.ELIC = Math.Round(enter.lic);
                    commit.EEPF = Math.Round(enter.pf);
                    commit.EESI = Math.Round(enter.ESI);
                    commit.EEESI = Math.Round(enter.ESI * (4.75 / 1.75));
                    commit.EGross = Math.Round(enter.total);
                    commit.ENet = Math.Round(enter.net);

                    _context.SaveChanges();
                }
               
            }
           

            var commits = _context.Commitment.ToList();
            foreach (var commit in commits)
            {
                double grosstot = 0;
                double grosspf = 0;
                double nettot = 0;
                double ESI = 0;
                double EESI = 0;
                double LIC = 0;
                double grosstotL = 0;
                double grosspfL = 0;
                double nettotL = 0;
                double ESIL = 0;
                double EESIL = 0;
                double LICL = 0;
                var lemployee = _context.Master.Where(m => m.placeid == commit.placeid.ToString()).ToList();
               

                foreach (var emp in lemployee)
                {
                    if ( emp.issued == false)
                    {
                        if (emp.grosswages != null)
                        {
                            grosstotL = (double)(grosstotL + emp.grosswages);
                        }
                        else
                        {
                            emp.grosswages = 0;
                            grosstotL = (double)(grosstotL + emp.grosswages);
                        }
                        if (emp.pf != null)
                        {
                            grosspfL = (double)(grosspfL + emp.pf);
                        }
                        else
                        {
                            emp.pf = 0;
                            grosspfL = (double)(grosspfL + emp.pf);
                        }

                        if (emp.netwages != null)
                        {
                            nettotL = (double)(nettotL + emp.netwages);
                        }
                        else
                        {
                            emp.netwages = 0;
                            nettotL = (double)(nettotL + emp.netwages);

                        }

                        if (emp.esi != null)
                        {
                            ESIL = (double)(ESIL + emp.esi);

                        }
                        else
                        {
                            emp.esi = 0;
                            ESIL = (double)(ESIL + emp.esi);
                        }

                        if (emp.LIC != null)
                        {
                            LICL = (double)(LICL + emp.LIC);
                        }
                        else
                        {
                            emp.LIC = 0;
                            LICL = (double)(LICL + emp.LIC);
                        }



                    }


                    if (emp.grosswages != null)
                    {
                        grosstot = (double) (grosstot + emp.grosswages);
                    }
                    else
                    {
                        emp.grosswages = 0;
                        grosstot = (double)(grosstot + emp.grosswages);
                    }

                    if (emp.pf != null)
                    {
                        grosspf = (double) (grosspf + emp.pf);
                    }
                    else
                    {
                        emp.pf = 0;
                        grosspf = (double)(grosspf + emp.pf);
                    }

                    if (emp.netwages != null)
                    {
                        nettot = (double) (nettot + emp.netwages);
                    }
                    else
                    {
                        emp.netwages = 0;
                        nettot = (double)(nettot + emp.netwages);

                    }

                    if (emp.esi != null)
                    {
                        ESI = (double) (ESI + emp.esi);

                    }
                    else
                    {
                        emp.esi = 0;
                        ESI = (double)(ESI + emp.esi);
                    }

                    if (emp.LIC != null)
                    {
                        LIC = (double) (LIC + emp.LIC);
                    }
                    else
                    {
                        emp.LIC = 0;
                        LIC = (double)(LIC + emp.LIC);
                    }
                   

                }

                double? pesi = 0;
                double? peesi = 0;
                var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid == commit.placeid);
                if (place != null)
                {
                    pesi = place.EmployeeEsi == null ? 1.75 : place.EmployeeEsi;
                    peesi = place.EmployerEsi == null ? 4.75 : place.EmployerEsi;
                }
                else
                {
                    pesi = 1.75;
                    peesi = 4.75;
                }
               

                EESI = (double)(ESI * (peesi / 100));
                ESI = (double) (ESI * (pesi / 100));
                
                commit.LESI = Math.Round(ESI);
                commit.LEESI = Math.Round(EESI);
                commit.LEPF = Math.Round(grosspf);
                commit.LPF = Math.Round(grosspf);
                commit.LNET = Math.Round(nettot);
                commit.LLIC = Math.Round(LIC);
                commit.LGross =Math.Round( grosstot);

                commit.PLESI = Math.Round(ESIL);
                commit.PLEESI = Math.Round(EESIL);
                commit.PLEPF = Math.Round(grosspfL);
                commit.PLPF = Math.Round(grosspfL);
                commit.PLNET = Math.Round(nettotL);
                commit.PLLIC = Math.Round(LICL);
                commit.PLGross =Math.Round( grosstotL);

                _context.SaveChanges();
            }

         

            var result = new ProcessSalary()
            {
                IsSuccessful = true
            };
            return View("ProcessResult", result);
        }

       

        public ActionResult SiteEdit(int id,string user)
        {
            var sub = _context.Sub.Where(m => m.PlaceId == id).ToList();

            if (sub == null)
            {
                var siteadmin = new SiteAdminViewModel()
                {
                    Default = "Direct",
                    DefaultId = id,
                    checkCord = false,
                    user = user
                };

                return View("manage", siteadmin);
            }

            var issite = new SiteAdminViewModel()
            {
                SubContractor = sub,
                DefaultId = id,
                Default = String.Empty,
                user = user,
                checkCord = false
                

            };
            return View("manage", issite);



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
                new SelectListItem {Text = "Direct", Value = "0"}
            };
            var sub = _context.Sub.Where(m => m.PlaceId.ToString() == emp.placeid).ToList();
            var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid.ToString() == emp.placeid);
            foreach (var s in sub)
            {
                var append = new SelectListItem {Text = s.SubContractorName, Value = s.SubContractId.ToString()};
                subcontractlist.Add(append);
            }
            if (emp.doj == null)
            {
                emp.doj = DateTime.Now.ToShortDateString();
            }

            if (emp.dob == null)
            {
                emp.dob = DateTime.Now.ToShortDateString();
            }
            var DOB = DateTime.Today;
            var DOJ = DateTime.Today;

            




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
                pfelig = emp.pfelig != null && (bool) emp.pfelig,
                ifsccode = emp.ifsccode,
                otpperhour = emp.otpperhour,
                perdaysalary = emp.perdaysalary,
                esicode = emp.esicode,
                esielig = emp.esielig != null && (bool) emp.esielig,
                state = emp.state,
                phoneno = emp.phoneno,
                fname = emp.fname,
                Placeid = Convert.ToInt32(emp.placeid),
                SubId = (int) emp.SUBID,
                placeName =place.PlaceName,
               
                 



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
                    new SelectListItem {Text = "Direct", Value = "0"}
                };
                var sub = _context.Sub.Where(m => m.PlaceId == Convert.ToInt32(emp1.placeid)).ToList();
                foreach (var s in sub)
                {
                    var append = new SelectListItem {Text = s.SubContractorName, Value = s.SubContractId.ToString()};
                    subcontractlist.Add(append);
                }

                var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid.ToString() == emp1.placeid);


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
                    dob = DateTime.Parse(emp1.dob, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None),
                    doj = DateTime.Parse(emp1.doj, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None),
                    emailId = emp1.emailId,
                    pincode = emp1.pincode,
                    panno = emp1.panno,
                    pfuan = emp1.pfuan,
                    pfelig = emp1.pfelig != null && (bool) emp.pfelig,
                    ifsccode = emp1.ifsccode,
                    otpperhour = emp1.otpperhour,
                    perdaysalary = emp1.perdaysalary,
                    esicode = emp1.esicode,
                    esielig = emp1.esielig != null && (bool) emp.esielig,
                    state = emp1.state,
                    phoneno = emp1.phoneno,
                    fname = emp1.fname,
                    Placeid = Convert.ToInt32(emp1.placeid),
                    SubId = Convert.ToInt32(emp1.SUBID),
                    placeName = place.PlaceName
                    


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
            selected.pfelig = emp.pfelig != null && (bool) emp.pfelig;
            selected.ifsccode = emp.ifsccode;
            selected.otpperhour = emp.otpperhour;
            selected.perdaysalary = emp.perdaysalary;
            selected.esicode = emp.esicode;
            selected.esielig = emp.esielig != null && (bool) emp.esielig;
            selected.state = emp.state;
            selected.phoneno = emp.phoneno;
            selected.fname = emp.fname;
            selected.placeid = emp.Placeid.ToString();
            _context.SaveChanges();
            if (emp.SubId == 0)
            {
                return RedirectToAction("Default", "SitePortal", new {id = emp.Placeid,user="admin"});
            }

            return RedirectToAction("ViewSite", "SitePortal", new {id = emp.SubId,user="admin"});


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
            var sub = _context.Master.Where(m => m.SUBID == id).ToList();
            var validate = new validateatsite()
            {
                Employees = sub,
                User = "admin"
            };
            return View("SiteView", validate);
        }

        public ActionResult GenerateReportForSub(int id)
        {
          
              var employees = _context.Master.Where(m => m.SUBID ==id).ToList();
            var sub = _context.Sub.SingleOrDefault(m => m.SubContractId == id);
            var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid == sub.PlaceId);
            if (place == null)
            {
                return HttpNotFound();
            }

            if (sub == null)
            {
                return HttpNotFound();
            }
            
            var report = new ReportModel()
            {
                Employees = employees,
                PlaceName = place.PlaceName,
                SubName = sub.SubContractorName,
                EmployerEsi = place.EmployerEsi


            };
            return View("Monthly", report);

        }

        public ActionResult ViewSubForDirect(int id)
        {
            var employees = _context.Master.Where(m => m.placeid == id.ToString() && (m.SUBID == null || m.SUBID <= 0)).ToList();
            var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid == id);
            var report = new ReportModel()
            {
                Employees = employees,
                PlaceName = place.PlaceName,
                SubName = "Direct Employee",
                EmployerEsi = place.EmployerEsi
                

            };
            return View("Monthly", report);
        }

        public ActionResult ViewSite(int id,string user)
        {
            var sub = _context.Master.Where(m => m.SUBID == id).ToList();
            var validate = new validateatsite()
            {
                Employees = sub,
                User = user
            };
            return View("SiteView", validate);
        }

        public ActionResult Default(int id,string user)
        {
            var emp = _context.Master.Where(m => m.placeid == id.ToString() && (m.SUBID == null || m.SUBID <= 0))
                .ToList();
            var validate = new validateatsite()
            {
                Employees = emp,
                User = user
            };
            return View("SiteView", validate);
        }

        public ActionResult EditSalaryDetails(int id,string user)
        {
            var emp = _context.Master.SingleOrDefault(m => m.EmpId == id);
            if (emp == null)
            {
                return HttpNotFound("Please Contact Of Admin");
            }

            var salary = new SalaryDetails()
            {
                Name = emp.name,
                Design = emp.Design,
                EmpId = emp.EmpId,
                nod = emp.nod,
                nodcoff = emp.nodcoff,
                nohours = emp.nohours,
                Otherallow = emp.otherallow,
                HouseRent = emp.HouseRent,
                tea = emp.TEA,
                Advances = emp.advance,
                recovery = emp.revocery,
                ptax = emp.ptax,
                TDS = emp.TDS,
                CLBAL = emp.clbal,
                CLCR = emp.clcr,
                CLTAK = emp.cltax,
                date = Convert.ToDateTime(emp.date),
                issued = emp.issued != null && (bool) emp.issued,
                issueDate = emp.issueDate,
                resigned = emp.resigned != null && (bool) emp.resigned,
                resignedDate = emp.resignedDate,
                LIC = emp.LIC,
                user = user




            };
            return View("Salary", salary);
        }
        [HttpPost]
        public ActionResult SetSalary(SetCurrentDate currentDate)
        {
            var emp = _context.Master.ToList();
            foreach (var e in emp)
            {
                e.date = currentDate.date.ToShortDateString();
            }

            return RedirectToAction("Manage", "Home");
        }

        [HttpPost]
        public ActionResult UpdateSalary(SalaryDetails salary,string user)
        {
            var emp = _context.Master.SingleOrDefault(m => m.EmpId == salary.EmpId);
            if (emp == null)
            {
                return HttpNotFound("Please Contact Admin");
            }

            emp.nod = salary.nod;
            emp.nodcoff = salary.nodcoff;
            emp.nohours = salary.nohours;
            emp.date = salary.date.ToShortDateString();
            emp.advance = salary.Advances;
            emp.HouseRent = (int?) salary.HouseRent;
            emp.TEA = salary.tea;
            emp.revocery = salary.recovery;
            emp.TDS = salary.TDS;
            emp.clcr = salary.CLCR;
            emp.cltax = salary.CLTAK;
            emp.clbal = salary.CLBAL;
            emp.ptax = salary.ptax;
            emp.otherallow = salary.Otherallow;
            emp.issued = salary.issued;
            emp.issueDate = salary.issueDate;
            emp.resigned = salary.resigned;
            emp.resignedDate = salary.resignedDate;
            emp.LIC = salary.LIC;

            _context.SaveChanges();
            if (emp.SUBID != null && emp.SUBID > 0)
            {
                return RedirectToAction("ViewSite", "SitePortal", new {id = emp.SUBID,user=user});
            }

            return RedirectToAction("Default", "SitePortal", new {id = emp.placeid,user=user});



        }

        // GET: SitePortal
        public ActionResult Index()
        {
            var newLogin = new SiteValidLogin()
            {
                EmployeeId = 0,
                ErrorMessage = "",
                IsValid = true,
                Password = "",
                PlaceName = ""
            };
            return View("Index", newLogin);
        }

        public ActionResult Addlocal(int id,string user)
        {

            var subContracts = _context.Sub.Where(m => m.PlaceId == id).ToList();
            var listselectitem = new List<SelectListItem>();
            if (subContracts == null) 
            {
                // listselectitem.Add(new SelectListItem{Value = "0",Text="Only Direct Employee No Subcontracators available"});
            }
            foreach (var sub in subContracts)
            {
                listselectitem.Add(new SelectListItem
                {
                    Value = sub.SubContractId.ToString(),
                    Text = sub.SubContractorName
                });
            }

            listselectitem.Add(new SelectListItem {Value = "0", Text = "Direct"});


            var master = new MasterSiteViewModel()
            {
                name = "",
                Design = "",
                SubContractor = listselectitem,
                esielig = true,
                pfelig = true,
                Placeid = id,
                user = user

            };
            foreach (var sub in subContracts)
            {
                master.SubContractor.Append(new SelectListItem
                {
                    Value = sub.SubContractId.ToString(),
                    Text = sub.SubContractorName.ToString()
                });

            }

            return View("AddlocalEmployee", master);

        }

        public ActionResult EnterCurrentDate()
        {
            var dob = new SetCurrentDate()
            {
                date = DateTime.Today
            };
            return View("CurrentDate", dob);
        }

        [HttpPost]
        public ActionResult Login(SiteValidLogin sitelogin)
        {

            var employee = _context.Employee3.SingleOrDefault(m => m.EmployeeId == sitelogin.EmployeeId);
            if (employee == null)
            {
                sitelogin.IsValid = false;
                sitelogin.ErrorMessage = "Please enter a valid EmployeeId";
                return View("Index", sitelogin);

            }

            var place = _context.SiteAdmin.SingleOrDefault(m => m.EmployeeId == employee.EmployeeId);
            if (place == null)
            {
                sitelogin.IsValid = false;
                sitelogin.ErrorMessage = "Please enter a valid Site Manager EmployeeId";
                return View("Index", sitelogin);

            }

            if (place.EmployeeId == sitelogin.EmployeeId && place.Password == sitelogin.Password)
            {

                return View("Success", place);
            }

            sitelogin.IsValid = false;
            sitelogin.ErrorMessage = "Details entered seems to be incorrect.Please recheck your details";
            return View("Index", sitelogin);
        }

        [HttpPost]
        public ActionResult AddEmployee(MasterSiteViewModel local,string user)
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
                if (subContracts == null) 
                {
                    // listselectitem.Add(new SelectListItem{Value = "0",Text="Only Direct Employee No Subcontracators available"});
                }
                foreach (var sub in subContracts)
                {
                    listselectitem.Add(new SelectListItem
                    {
                        Value = sub.SubContractId.ToString(),
                        Text = sub.SubContractorName
                    });
                }

                listselectitem.Add(new SelectListItem {Value = "0", Text = "Direct"});


                var master = new MasterSiteViewModel()
                {
                    name = "",
                    Design = "",
                    SubContractor = listselectitem,
                    esielig = true,
                    pfelig = true,
                    Placeid = (int) place.Placeid

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
            var sub1 = _context.Sub.SingleOrDefault(m => m.SubContractId == local.SubId);
            if (sub1== null) 
           

            {
                var place1 = _context.SiteAdmin.SingleOrDefault(m => m.Placeid == local.Placeid);
                return RedirectToAction("Default", "SitePortal", new {id = place1.Placeid, user = user});

            }

            return RedirectToAction("ViewSite", "SitePortal", new {id = sub1.SubContractId, user = user});
                

           
        }

        public ActionResult PlaceReport()
        {
            var places = _context.SiteAdmin.ToList();
            var subs = _context.Sub.ToList();
            var employees = _context.Master.ToList();
            var report = new PlaceReportModel()
            {
                Employees = employees,
                Sites = places,
                SubContracts = subs
            };
            return View("Report", report);
        }
      
        public void ExportClientList(int id)
        {
            StringWriter sw = new StringWriter();
            sw.WriteLine("\"Empid\",\"Name\",\"Designation\",\"perdaysalary\",\"No of Days Worked\",\"total\",\"NOD-COFF\",\"COFF-Amount\",\"OT per hour\",\"No of hours \",\"OT Amount\",\"TEA\",\"House Rent\",\"Other Allowances\",\"Gross Wages\",\"Advances\",\"Recovery\",\"PF\",\"ESI\",\"Professional Tax\",\"TDS\",\"LIC\",\"Deduction Total\",\"Net Wages\",\"PF UAN\",\"PF Memeber Id\",\"Date of Birth\",\"Father's Name\",\"Bank Name\",\"Account No\",\"Branch\",\"IFSC Code\",\"ESI Code\",\"Place Name\",\"SUB-Contractor Name\",\"Date\",\"Address\",\"State\",\"Pincode\",\"Mobile Number\",\"Email Id\",\"Aadhar Number\",\"Pan Number\",\"Date of Joining\",\"Professional Tax\",\"CL-Credit\",\"Cl-Taken\",\"Cl-Balance\",\"Issued\",\"Issued Date\",\"Resigned\",\"Resigned Date\"");
            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=place"+id+".csv");
            Response.ContentType = "text/csv";
            var employees = _context.Master.Where(m => m.placeid == id.ToString()).ToList();
            foreach (var emp in employees)
            {
                var placename = string.Empty;
                var subname = string.Empty;
                var sub = _context.Sub.SingleOrDefault(m => m.SubContractId == emp.SUBID);

                var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid.ToString() == emp.placeid);
                placename = place == null ? "" : place.PlaceName;
                subname = sub == null || sub.SubContractId == 0 ? "Direct" : sub.SubContractorName;
                sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\",\"{13}\",\"{14}\",\"{15}\",\"{16}\",\"{17}\",\"{18}\",\"{19}\",\"{20}\",\"{21}\",\"{22}\",\"{23}\",\"{24}\",\"{25}\",\"{26}\",\"{27}\",\"{28}\",\"{29}\",\"{30}\",\"{31}\",\"{32}\",\"{33}\",\"{34}\",\"{35}\",\"{36}\",\"{37}\",\"{38}\",\"{39}\",\"{40}\",\"{41}\",\"{42}\",\"{43}\",\"{44}\",\"{45}\",\"{46}\",\"{47}\",\"{48}\",\"{49}\",\"{50}\",\"{51}\"",
                    emp.EmpId, emp.name, emp.Design, emp.perdaysalary, emp.nod, emp.total, emp.nodcoff, emp.coggamt, emp.otpperhour, emp.nohours, emp.otamt, emp.TEA, emp.HouseRent, emp.otherallow, emp.grosswages, emp.advance, emp.revocery, emp.pf, emp.esi, emp.ptax, emp.TDS, emp.LIC, emp.dedtot, emp.netwages, emp.pfuan,emp.pfMemberId, emp.dob, emp.fname, emp.BankName, emp.bankacno, emp.branch, emp.ifsccode, emp.esicode, placename, subname, emp.date, emp.address, emp.state, emp.pincode, emp.phoneno, emp.emailId, emp.aadharno, emp.panno, emp.doj, emp.photo, emp.clcr, emp.cltax, emp.clbal, emp.issueDate, emp.issued, emp.resigned, emp.resignedDate));

            }
            Response.Write(sw.ToString());

            Response.End();



        }

        public void ExportClientsListToCSV()
        {
            StringWriter sw = new StringWriter();
            sw.WriteLine("\"Empid\",\"Name\",\"Designation\",\"perdaysalary\",\"No of Days Worked\",\"total\",\"NOD-COFF\",\"COFF-Amount\",\"OT per hour\",\"No of hours \",\"OT Amount\",\"TEA\",\"House Rent\",\"Other Allowances\",\"Gross Wages\",\"Advances\",\"Recovery\",\"PF\",\"ESI\",\"Professional Tax\",\"TDS\",\"LIC\",\"Deduction Total\",\"Net Wages\",\"PF UAN\",\"PF Member Id\",\"Date of Birth\",\"Father's Name\",\"Bank Name\",\"Account No\",\"Branch\",\"IFSC Code\",\"ESI Code\",\"Place Name\",\"SUB-Contractor Name\",\"Date\",\"Address\",\"State\",\"Pincode\",\"Mobile Number\",\"Email Id\",\"Aadhar Number\",\"Pan Number\",\"Date of Joining\",\"Professional Tax\",\"CL-Credit\",\"Cl-Taken\",\"Cl-Balance\",\"Issued\",\"Issued Date\",\"Resigned\",\"Resigned Date\"");
            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=Exported_Users.csv");
            Response.ContentType = "text/csv";
            var employees = _context.Master.ToList();
            foreach (var emp in employees)
            {
                var placename = string.Empty;
                var subname = string.Empty;
                var sub = _context.Sub.SingleOrDefault(m => m.SubContractId == emp.SUBID);
                
                var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid.ToString() == emp.placeid);
                placename = place == null ? "" : place.PlaceName;
                subname = sub == null || sub.SubContractId == 0 ? "Direct" : sub.SubContractorName;
                sw.WriteLine(string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",\"{8}\",\"{9}\",\"{10}\",\"{11}\",\"{12}\",\"{13}\",\"{14}\",\"{15}\",\"{16}\",\"{17}\",\"{18}\",\"{19}\",\"{20}\",\"{21}\",\"{22}\",\"{23}\",\"{24}\",\"{25}\",\"{26}\",\"{27}\",\"{28}\",\"{29}\",\"{30}\",\"{31}\",\"{32}\",\"{33}\",\"{34}\",\"{35}\",\"{36}\",\"{37}\",\"{38}\",\"{39}\",\"{40}\",\"{41}\",\"{42}\",\"{43}\",\"{44}\",\"{45}\",\"{46}\",\"{47}\",\"{48}\",\"{49}\",\"{50}\",\"{51}\"",
                    emp.EmpId,emp.name,emp.Design,emp.perdaysalary,emp.nod,emp.total,emp.nodcoff,emp.coggamt,emp.otpperhour,emp.nohours,emp.otamt,emp.TEA,emp.HouseRent,emp.otherallow,emp.grosswages,emp.advance,emp.revocery,emp.pf,emp.esi,emp.ptax,emp.TDS,emp.LIC,emp.dedtot,emp.netwages,emp.pfuan,emp.pfMemberId,emp.dob,emp.fname,emp.BankName,emp.bankacno,emp.branch,emp.ifsccode,emp.esicode,placename,subname,emp.date,emp.address,emp.state,emp.pincode,emp.phoneno,emp.emailId,emp.aadharno,emp.panno,emp.doj,emp.photo,emp.clcr,emp.cltax,emp.clbal,emp.issued,emp.issueDate,emp.resigned,emp.resignedDate));

            }
            Response.Write(sw.ToString());

            Response.End();


        }
        [HttpPost]
        [ValidateInput(false)]
        public FileResult Export(string GridHtml)
        {
            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader sr = new StringReader(GridHtml);
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "Grid.pdf");
            }
        }

        public ActionResult AddImage(int id,string user)
        {
            int sid = 0;
            int placid = 0;
            var emp = _context.Master.SingleOrDefault(m => m.EmpId == id);
            var sub = _context.Sub.SingleOrDefault(m => m.SubContractId == emp.SUBID);
            var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid.ToString() == emp.placeid);
            if (sub == null)
            {
                placid = (int)place.Placeid;

            }
            else
            {
                sid = sub.SubContractId;
            }
            var image = new UploadImage()
            {
                EmpId = id,
                isValid = true,
                ErrorMessage = "Please Upload the Image",
                User=user,
                subId = sid,
                placeId = placid
               
                
            };
            return View("uploadAadhar", image);
        }
        public ActionResult DeleteImageForBank(string filename, int id,string user)
        {
            int sid = 0;
            int placid = 0;
            var emp = _context.Master.SingleOrDefault(m => m.EmpId == id);
            var sub = _context.Sub.SingleOrDefault(m => m.SubContractId == emp.SUBID);
            var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid.ToString() == emp.placeid);
            if (sub == null)
            {
                placid = (int)place.Placeid;

            }
            else
            {
                sid = sub.SubContractId;
            }
            string fullpath = Request.MapPath("~/BankPhotos/" + filename);

            if (System.IO.File.Exists(fullpath))
            {

                System.IO.File.Delete(fullpath);
                var UploadImage = new UploadImage()
                {
                    isValid = true,
                    EmpId = id,
                    ErrorMessage = "File Deleted Successfully",
                    User = user,
                    subId = sid,
                    placeId = placid

                };
                return View("uploadAadhar", UploadImage);
            }
            var fail = new UploadImage()
            {
                EmpId = id,
                ErrorMessage = "Unable to Delete the file",
                isValid = false,
                User = user,
                subId = sid,
                placeId = placid
            };
            return View("uploadAadhar", fail);
        }

        public ActionResult DeleteImageForAadhar(string filename,int id,string user)
        {
            int sid = 0;
            int placid = 0;
            var emp = _context.Master.SingleOrDefault(m => m.EmpId == id);
            var sub = _context.Sub.SingleOrDefault(m => m.SubContractId == emp.SUBID);
            var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid.ToString() == emp.placeid);
            if (sub == null)
            {
                placid = (int)place.Placeid;

            }
            else
            {
                sid = sub.SubContractId;
            }
            string fullpath = Request.MapPath("~/AadharPhotos/" + filename);
           
            if (System.IO.File.Exists(fullpath))
            {
              
                System.IO.File.Delete(fullpath);
                var UploadImage = new UploadImage()
                {
                    isValid = true,
                    EmpId = id,
                    ErrorMessage = "File Deleted Successfully",
                    User = user,
                    placeId = placid,
                    subId = sid

                };
                return View("uploadAadhar", UploadImage);
            }
            var fail = new UploadImage()
            {
                EmpId = id,
                ErrorMessage = "Unable to Delete the file",
                isValid = false,
                User = user,
                placeId = placid,
                subId = sid

            };
            return View("uploadAadhar", fail);
        }

        public ActionResult FileUploadForBank(HttpPostedFileBase file, int id,string user)
        {
            int sid = 0;
            int placid = 0;
            var emp = _context.Master.SingleOrDefault(m => m.EmpId == id);
            var sub = _context.Sub.SingleOrDefault(m => m.SubContractId == emp.SUBID);
            var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid.ToString() == emp.placeid);
            if (sub == null)
            {
                placid = (int)place.Placeid;

            }
            else
            {
                sid = sub.SubContractId;
            }

            string dir = Server.MapPath("~/BankPhotos/");
            var files = dir + "Emp" + id + ".jpg";
            if (System.IO.File.Exists(files))
            {
                var failureexit = new UploadImage()
                {
                    ErrorMessage = "File Exists.Please delete the existing photo and try again ",
                    isValid = false,
                    EmpId = id,
                    User = user,
                    placeId = placid,
                    subId = sid
                };
                return View("uploadAadhar", failureexit);

            }
            if (file != null)
            {


                string pic = System.IO.Path.GetFileName(file.FileName);
                FileInfo fileInfo = new FileInfo(pic);
                string ext = fileInfo.Extension;
               
                string newfilename = "Emp" + id;
                file.SaveAs(Path.Combine(dir, Path.GetFileName(newfilename + ext)));
                var image = new UploadImage()
                {
                    ErrorMessage = "Successfull uploaded Image for Bank Pass Book",
                    isValid = true,
                    EmpId = id,
                    User = user,
                    placeId = placid,
                    subId = sid

                };
                return View("uploadAadhar", image);
            }
            var failure = new UploadImage()
            {
                ErrorMessage = "Unable to upload the image for Bank Passbook please try again",
                isValid = false,
                EmpId = id,
                User = user,
                placeId = placid,
                subId = sid
            };
            return View("uploadAadhar", failure);

        }
        public ActionResult FileUpload(HttpPostedFileBase file,int id,string user)
        {
            int sid = 0;
            int placid = 0;
            var emp = _context.Master.SingleOrDefault(m => m.EmpId == id);
            var sub = _context.Sub.SingleOrDefault(m => m.SubContractId == emp.SUBID);
            var place = _context.SiteAdmin.SingleOrDefault(m => m.Placeid.ToString() == emp.placeid);
            if (sub == null)
            {
                placid = (int)place.Placeid;

            }
            else
            {
                sid = sub.SubContractId;
            }
            string dir = Server.MapPath("~/AadharPhotos/");
            string filename = dir + "Emp" + id + ".jpg";
            if (System.IO.File.Exists(filename))
            {
                var failureexit = new UploadImage()
                {
                    ErrorMessage = "File Exists.Please delete the existing photo and try again ",
                    isValid = false,
                    EmpId = id,
                    User = user,
                    placeId = placid,
                    subId = sid
                };
                return View("uploadAadhar", failureexit);

            }

                if (file != null)
            {
               

                string pic = System.IO.Path.GetFileName(file.FileName);
                FileInfo fileInfo = new FileInfo(pic);
                string ext = fileInfo.Extension;
              //  string dir = Server.MapPath("~/AadharPhotos/");
                string newfilename = "Emp" + id;
                file.SaveAs(Path.Combine(dir, Path.GetFileName(newfilename  + ext)));
                var image = new UploadImage()
                {
                    ErrorMessage = "Successfully Uploaded Aadhar Image",
                    isValid = true,
                    EmpId = id,
                    User = user,
                    placeId = placid,
                    subId = sid

                };
                return View("uploadAadhar", image);
            }
            var failure = new UploadImage()
            {
                ErrorMessage = "Unable to upload the image for Aadhar,please try again",
                isValid = false,
                EmpId = id,
                User = user,
                placeId = placid,
                subId = sid
            };
            return View("uploadAadhar", failure);
        }
    }
}