﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheminPayslip.Models
{
    public class expensetype
    {
        public int Id { get; set; }
        public string expenseType { get; set; }
        public int groupid { get; set; }
    }
}