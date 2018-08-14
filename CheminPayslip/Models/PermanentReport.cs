using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class PermanentReport
    {
        public string placename { get; set; }
        public string name { get; set; }
        public string Design { get; set; }
        public double? Total { get; set; }
        public double? PF { get; set; }
        public double? ESI { get; set; }
        public double? LIC { get; set; }
        public double? NetWages { get; set; }
        public string grade { get; set; }
        public int? EmpId { get; set; }
        public double? advance { get; set; }
    }
}