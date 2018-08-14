using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class Site
    {
        public int Id { get; set; }

        public long Placeid { get; set; }

        public string PlaceName { get; set; }

        public int  EmployeeId { get; set; }

        public string  Password { get; set; }

       

        public string CoordPassword { get; set; }
        public double? EmployeeEsi { get; set; }
        public double? EmployerEsi { get; set; }
        public double? Grosstot { get; set; }
        public double? Esitot { get; set; }
        public double? Eetot { get; set; }
        public double? Nettot { get; set; }
        public double? opbal { get; set; }
        public double? clbal { get; set; }
        public bool? Active { get; set; }
        public double? Adhoc { get; set; }
        public string startDate { get; set; }
        public string EndDate { get; set; }
        public double? billTotal { get; set; }
        public double? BudTotal { get; set; }
        public double? BudOutstanding { get; set; }   
    }
}