﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurnipTheBeetMKE.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public bool IsCustomer { get; set; }
        public bool HasSurvey { get; set; }
        public bool IsSubscribed { get; set; }
    }
}