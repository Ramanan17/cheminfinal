using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class ResetPassword
    {
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }
        [Display(Name = "Employee Id")]
        public int EmployeeId { get; set; }
        [Display(Name = "New Password")]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}