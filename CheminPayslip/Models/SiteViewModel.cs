using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class SiteViewModel
    {
        public int PlaceId { get; set; }
        public string PlaceName { get; set; }
        [Display(Name="Site Manager")]

        public string EmployeeName { get; set; }
        public string PassWord { get; set; }

        public string ErrorMessage { get; set; }
        public bool isValid { get; set; }
      [Display(Name = "Coordinator Password")]
       public string CoordPassword { get; set; }
        [Display(Name = "Esi for Employee in percentange")]
        public double? EmployeeEsi { get; set; }
        [Display(Name = "Esi for Employer in percentage")]
        public double? EmployerEsi { get; set; }

    }
}