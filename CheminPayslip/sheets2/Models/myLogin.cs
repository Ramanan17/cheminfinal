using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class myLogin
    {
        public int Id { get; set; }
        // public EmployeeDetails EmployeeDetails { get; set; }
        public int EmployeeDetailsId { get; set; }
        public string Password { get; set; }
    }
}