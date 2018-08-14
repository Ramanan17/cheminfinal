using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class AccTrans
    {
        public int Id { get; set; }
        public int placeid { get; set; }
      
        public int subid { get; set; }
 
        public int? booktypeid { get; set; }
        public int? exoensetypeid { get; set; }
        public int? voucherid { get; set; }
        public string date { get; set; }
        public double? budgetamt { get; set; }
        public double? amtpaid { get; set; }
        public double? adhocrecd { get; set; }
        public double? amtcred { get; set; }
        public string billno{ get; set; }
        public double? billamt { get; set; }
        public double? retamt { get; set; }
        public double? balance { get; set; }
        public int modelid { get; set; }
        public int neftid { get; set; }
        public string varchar { get; set; }
        public double misc { get; set; }
        public bool approved { get; set; }



    }
}