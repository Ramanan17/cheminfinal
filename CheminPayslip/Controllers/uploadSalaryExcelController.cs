using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheminPayslip.Models;
using LinqToExcel;

namespace CheminPayslip.Controllers
{
    public class uploadSalaryExcelController : Controller
    {
        // GET: uploadSalaryExcel
        private ApplicationDbContext _context;

        public uploadSalaryExcelController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult ExcelUpload()
        {
            return View("ExcelUpload");
        }
        [HttpPost]
        public ActionResult UploadExcel(EmployeeDetails objEmployeeDetails, HttpPostedFileBase fileUpload)
        {
           

            if (fileUpload != null)
            {
                string data = "";
                if (fileUpload.ContentType == "application/vnd.ms-excel" || fileUpload.ContentType ==
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                {
                    string filename = fileUpload.FileName;
                    if (filename.EndsWith(".xlsx") || filename.EndsWith(".csv"))
                    {
                        string targetpath = Server.MapPath("~/sheets2/");
                        fileUpload.SaveAs(targetpath + filename);
                        string pathToExcelFile = targetpath + filename;
                        string sheetName = "Sheet1";
                        var excelFile = new ExcelQueryFactory(pathToExcelFile);
                        var empdetails = from a in excelFile.Worksheet<salaryViewModel>(sheetName) select a;
                        foreach (var a in empdetails)
                        {

                            if (a.EmpId != null)
                            {
                                var emp = _context.Master.SingleOrDefault(m => m.EmpId == a.EmpId);
                                if (emp == null)
                                {
                                    data = "Please check your excel sheet,You have entered invalid employee in the excel sheet";
                                    ViewBag.Message = data;
                                    return View("ExcelUpload");
                                }

                                emp.nod = a.nod;
                                emp.nodcoff = a.nodcoff;
                                emp.nohours = a.nohours;
                                emp.TEA = a.tea;
                                emp.HouseRent = a.HouseRent;
                                emp.otherallow = a.Otherallow;
                                emp.advance = a.Advances;
                                emp.revocery = a.recovery;
                                emp.ptax = a.ptax;
                                emp.TDS = a.TDS;
                                emp.clcr = a.CLCR;
                                emp.clbal = a.CLBAL;
                                emp.cltax = a.CLTAK;

                                _context.SaveChanges();


                            }
                            else
                            {
                                data = "Please check your excel sheet,There is a problem";
                                ViewBag.Message = data;
                                return View("ExcelUpload");


                            }

                        }

                        
                        data = "Successful upload records";
                        ViewBag.Message = data;
                    }
                    else
                    {
                        data = "Please upload spreadsheet of the form csv";
                        ViewBag.Message = data;
                        return View("ExcelUpload");
                    }
                }
                else
                {
                    data = "Please upload a spreadsheet";
                    return View("ExcelUpload");
                }
            }


            return View("ExcelUpload");
        }

    }
}