using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class nefttable
    {
        public int Id { get; set; }
        public int Placeid { get; set; }
        public string Accname { get; set; }
        public string Bank { get; set; }
        public string Branch { get; set; }
        public string IFSCCODE { get; set; }
    }
}