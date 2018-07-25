using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class locallogin
    {
        [Display(Name = "Please enter your Employee Id")]
        public string EmpId { get; set; }
        public string ErrorMessage { get; set; }
        public bool isValid { get; set; }
    }
}