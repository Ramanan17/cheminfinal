using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class TableValid
    {
        public int  Id { get; set; }
        public string TableName { get; set; }
        public Boolean IsValid { get; set; }
    }
}