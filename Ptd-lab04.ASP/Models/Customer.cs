﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ptd_lab04.ASP.Models
{
    public class PtdCustomer
    {
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Balance { get; set; }
    }
}