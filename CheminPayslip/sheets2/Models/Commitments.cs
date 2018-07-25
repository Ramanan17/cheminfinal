using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class Commitments
    {
        public int Id { get; set; }
        public int placeid { get; set; }
        public string PlaceName { get; set; }
        public int SUBID { get; set; }
        public string SubName { get; set; }
        public double? EGross { get; set; }
        public double? EPF { get; set; }
        public double? EESI { get; set; }
        public double? EEPF { get; set; }
        public double? EEESI { get; set; }
        public double? ENet { get; set; }
        public double? LGross { get; set; }
        public double? LPF { get; set; }
        public double? LESI { get; set; }
        public double? LEPF { get; set; }
        public double? LEESI { get; set; }
        public double? LNET { get; set; }
        public double? LLIC { get; set; }
        public double? PELIC { get; set; }
        public double? PEGross { get; set; }
        public double? PEPF { get; set; }
        public double? PEESI { get; set; }
        public double? PEEPF { get; set; }
        public double? PEEESI { get; set; }
        public double? PENet { get; set; }
        public double? PLGross { get; set; }
        public double? PLPF { get; set; }
        public double? PLESI { get; set; }
        public double? PLEPF { get; set; }
        public double? PLEESI { get; set; }
        public double? PLNET { get; set; }
        public double? PLLIC { get; set; }
        public double? ELIC { get; set; }












    }
}