using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class issueMoel
    {
        public int placeid { get; set; }
        public int SUBID { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public bool issue { get; set; }
        public string issueDate { get; set; }

    }
}