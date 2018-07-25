using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class CoordinatorforSite
    {
        public int  Id { get; set; }
        public string CoordinatorName { get; set; }
        public int EmpId { get; set; }
        public string PassWord { get; set; }
        public int  PlaceId { get; set; }
    }
}