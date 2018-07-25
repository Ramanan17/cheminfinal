using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheminPayslip.Models;
using LinqToExcel;

namespace CheminPayslip.Controllers
{
    public class ExcelDemo2Controller : Controller
    {
        // GET: ExcelDemo2
        private ApplicationDbContext _context;

        public ExcelDemo2Controller()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult ExcelUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadExcel(EmployeeDetails objEmployeeDetails, HttpPostedFileBase fileUpload)
        {
            string data = "";
            var total = _context.Employee2.ToList().Count;
            if (total != 0)
            {
                _context.Database.ExecuteSqlCommand("DELETE FROM EmployeeDetails2");

            }

            if (fileUpload != null)
            {
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
                        var empdetails = from a in excelFile.Worksheet<EmployeeDetails2>(sheetName) select a;
                        foreach (var a in empdetails)
                        {

                            if (a.EmployeeId != null)
                            {
                                _context.Employee2.Add(a);


                            }
                            else
                            {
                                data = "Please check your excel sheet,There is a problem";
                                ViewBag.Message = data;
                                return View("ExcelUpload");


                            }

                        }

                        _context.SaveChanges();
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