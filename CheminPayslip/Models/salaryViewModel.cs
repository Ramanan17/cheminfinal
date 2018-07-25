using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class salaryViewModel
    {
        public int EmpId { get; set; }
       
         public float? nod { get; set; }
       
        public float? nodcoff { get; set; }
        
        public float? nohours { get; set; }
    
        public float? tea { get; set; }
        
        public int? HouseRent { get; set; }
        
        public float? Otherallow { get; set; }
       
        public float? Advances { get; set; }
 
        public float? recovery { get; set; }
       
        public double? ptax { get; set; }

        public float? TDS { get; set; }
           public float? CLCR { get; set; }
       public float? CLBAL { get; set; }
          public float? CLTAK { get; set; }
        




    }
}