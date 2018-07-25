using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class PlaceReportModel
    {
        public List<Site> Sites { get; set; }
        public List<SubContract> SubContracts { get; set; }
        public List<MasterSite> Employees { get; set; }
    }
}