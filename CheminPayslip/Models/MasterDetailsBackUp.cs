using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using OfficeOpenXml.Utils;

namespace CheminPayslip.Models
{
    public class MasterDetailsBackUp
    {
        public int Id { get; set; }
        [Required]
        public int EmpId { get; set; }
        public string name { get; set; }
        public string Design { get; set; }
        public float? perdaysalary { get; set; }
        public float? nod { get; set; }
        public float? total { get; set; }
        public float? nodcoff { get; set; }
        public float? coggamt { get; set; }
        public float? otpperhour { get; set; }
        public float? nohours { get; set; }
        public float? otamt { get; set; }

        public float? TEA { get; set; }
        public float? grosswages { get; set; }
        public float? otherallow { get; set; }
        public float? advance { get; set; }
        public float? revocery { get; set; }
        public float? pf { get; set; }
        public float? esi { get; set; }
        public float? TDS { get; set; }
        public float? dedtot { get; set; }
        public float? netwages { get; set; }
        public string pfuan { get; set; }
        public string dob { get; set; }
        public string fname { get; set; }
        public string BankName { get; set; }
        public string bankacno { get; set; }
        public string branch { get; set; }
        public string ifsccode { get; set; }
        public string esicode { get; set; }
        public string placeid { get; set; }
        public string date { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public string pincode { get; set; }
        public double? phoneno { get; set; }
        public string emailId { get; set; }
        public string aadharno { get; set; }
        public string panno { get; set; }
        public string doj { get; set; }
        public byte[] photo { get; set; }
        public double? ptax { get; set; }
        public int? SUBID { get; set; }
        public int? HouseRent { get; set; }
        public float? clcr { get; set; }
        public float? cltax { get; set; }
        public float? clbal { get; set; }
        public string remarks { get; set; }
        public bool? pfelig { get; set; }
        public bool? esielig { get; set; }
        public string pfMemberId { get; set; }
        public double? LIC { get; set; }
        public bool? issued { get; set; }
        public string issueDate { get; set; }
        public bool? resigned { get; set; }
        public string resignedDate { get; set; }
        public string Misc { get; set; }
        public string Misc2 { get; set; }

    }
}