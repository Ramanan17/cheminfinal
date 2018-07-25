using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class ReportModel
    {
        public List<MasterSite> Employees { get; set; }
        public string PlaceName { get; set; }
        public string SubName { get; set; }
        public double? EmployerEsi { get; set; }
    }
}