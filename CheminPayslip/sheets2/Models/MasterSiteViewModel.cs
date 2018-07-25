using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace CheminPayslip.Models
{
    public class MasterSiteViewModel
    {

        public int Placeid { get; set; }
        [Required(ErrorMessage = "Enter the Name that is present in aadhar card")]
        [Display(Name = "Employee Name")]
        public string name { get; set; }
        [Required(ErrorMessage = "Enter the Designation")]
        [Display(Name = "Designation")]
        public string Design { get; set; }
        [Range(1,1000000,ErrorMessage = "Please enter a valid digit for per day salary")]
        [Display(Name="Salary per Day")]
        public float? perdaysalary { get; set; }

        [Display(Name = "Over Time(OT) pay per hour")]
        public float? otpperhour { get; set; }
       
        

        [Display(Name="Pf UAN")]
        public string pfuan { get; set; }
        [Display(Name="Date Of Birth")]
        [Required(ErrorMessage = "Please provide a date of birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime dob { get; set; }
        [Display(Name = "Father's Name")]
        public string fname { get; set; }
        [Display(Name = "Name of the Bank")]
        public string BankName { get; set; }
        [Display(Name = "Account Number")]
        public string bankacno { get; set; }
        [Display(Name = "Branch Name")]
        public string branch { get; set; }
        [Display(Name = "IFSC Code")]
        public string ifsccode { get; set; }
        [Display(Name = "ESI Code")]
        public string esicode { get; set; }
        

        [MinLength(5,ErrorMessage = "Enter a valid Address")]
        [Display(Name = "Address")]
        public string address { get; set; }
        [Display(Name="State")]
        public string state { get; set; }
        [Display(Name = "Pincode")]
        [Range(1,10000000)]
        public string pincode { get; set; }
        [Display(Name="Mobile Number")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public double? phoneno { get; set; }
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Enter a Valid Email")]
        public string emailId { get; set; }
        [Required(ErrorMessage = "Please Provide the Datae of Joining")]
        [Display(Name = "Aadhar Number")]
        public string aadharno { get; set; }
        [Display(Name = "Pan Number")]
        public string panno { get; set; }
        [Display(Name = "Date of Joining")]
        [Required(ErrorMessage = "Please provide the Date of Joining")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime doj { get; set; }
        
        public IEnumerable<SelectListItem> SubContractor { get; set; }
        [Display(Name = "Sub-Contractor Name")]
        public int SubId { get; set; }
        [Display(Name = "Eligibile for PF")]
        public bool pfelig { get; set; }
        [Display(Name = "Eligible for ESI")]
        public bool esielig { get; set; }

        public int? EmpId { get; set; }
        public string user { get; set; }

        public string placeName { get; set; }
        public string SubContractorName { get; set; }
    }
}