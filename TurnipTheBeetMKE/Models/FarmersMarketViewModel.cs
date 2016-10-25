﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurnipTheBeetMKE.Models
{
    public class FarmersMarketViewModel
    {
        public FarmersMarket farmersMarket { get; set; }
        public int FarmersMarketId { get; set; }
        [Display(Name = "Market Name")]
        public string marketname { get; set; }
        public string Schedule { get; set; }
        public string Address { get; set; }
        public string Products { get; set; }
    }
}