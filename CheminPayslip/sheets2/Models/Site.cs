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


    }
}