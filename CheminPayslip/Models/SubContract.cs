using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class SubContract
    {
        public int Id { get; set; }
        public int SubContractId { get; set; }
        public int PlaceId { get; set; }
        public string SubContractorName { get; set; }
        public double? Grosstot { get; set; }
        public double? Esitot { get; set; }
        public double? Eetot { get; set; }
        public double? Nettot { get; set; }


    }
}