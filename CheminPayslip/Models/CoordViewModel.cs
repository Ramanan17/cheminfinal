using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class CoordViewModel
    {
       
        public string Password { get; set; }
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }

    }
}