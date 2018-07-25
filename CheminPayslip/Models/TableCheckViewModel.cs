using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class TableCheckViewModel
    {
        
        public bool IsTable1Valid { get; set; }

        public bool IsTable2Valid { get; set; }

        public bool IsTable3Valid { get; set; }

        public string Message { get; set; }

        public bool processValid { get; set; }
    }
}