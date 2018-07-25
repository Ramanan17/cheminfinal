using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class SubcontractViewModel
    {
        public int SubContractId { get; set; }
        public string PlaceName { get; set; }
        public string SubContractorName { get; set; }
        public string ErrorMessage { get; set; }
        public bool Isvalid { get; set; }
    }
}