using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class SiteAdminViewModel
    {
        public List<SubContract> SubContractor { get; set; }
        public string Default { get; set; }
        public int DefaultId { get; set; }
        public string user { get; set; }
        public bool checkCord { get; set; }
    }
}