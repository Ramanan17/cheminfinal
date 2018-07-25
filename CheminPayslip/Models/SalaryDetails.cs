using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class SalaryDetails
    {
        public int EmpId { get; set; }
        [Required]
        public string  Name { get; set; }
        [Required]
        [Display(Name = "Designation")]
        public string Design { get; set; }
        [Display(Name = "Number of Days Worked")]
        public float? nod { get; set; }
        [Display(Name = "No of Days C-off")]
        public float? nodcoff { get; set; }
        [Display(Name = "OT Hours")]
        public float? nohours { get; set; }
        [Display(Name = "TEA")]
        public float? tea { get; set; }
        [Display(Name = "House Rent" )]
        public float? HouseRent { get; set; }
        [Display(Name = "Other Allowances")]
        public float? Otherallow { get; set; }
        [Display(Name = "Advances")]
        public float? Advances { get; set; }
        [Display(Name ="recovery" )]
        public float? recovery { get; set; }
        [Display(Name = "Professional tax")]
        public double? ptax { get; set; }

        public float? TDS { get; set; }
        [Display(Name = "CL Credit")]
        public float? CLCR { get; set; }
        [Display(Name = "CL-Balance")]

        public float? CLBAL { get; set; }
        [Display(Name = "CL-Taken")]
        public float? CLTAK { get; set; }

        [Display(Name="Date Of Salary")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime date { get; set; }

        public string user { get; set; }
        [Display(Name = "Issued")]
        public bool issued { get; set; }
        [Display(Name = "Issue Date")]

        public string issueDate { get; set; }
        [Display(Name = "Resigned")]
        public bool resigned { get; set; }
        [Display(Name = "Resigned Date")]
        public string resignedDate { get; set; }
        [Display(Name = "LIC")]
        public double? LIC { get; set; }

    }
}