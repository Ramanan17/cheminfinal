using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class locallist
    {
        public int  Id { get; set; }
        public int EmpId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string SubContractor { get; set; }
        public double? perday { get; set; }
        public string place { get; set; }
    }
}