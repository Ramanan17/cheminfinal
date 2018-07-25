using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheminPayslip.Models
{
    public class ValidateLogin
    {
        public bool Valid { get; set; }
        public string ErrorMessage { get; set; }
        public int EmployeeID { get; set; }
        public IEnumerable<SelectListItem> Month { get; set; }
        public int MonthVal { get; set; }
        public string Password { get; set; }
    }

    
}