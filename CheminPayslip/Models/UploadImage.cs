using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class UploadImage
    {
        public bool isValid { get; set; }
        public string ErrorMessage { get; set; }
        public int  EmpId { get; set; }
        public string User { get; set; }
        public int subId { get; set; }
        public int  placeId { get; set; }
    }
}