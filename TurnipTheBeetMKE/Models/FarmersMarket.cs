﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurnipTheBeetMKE.Models
{
    public class FarmersMarket
    {
        [Key]
        public int FarmersMarketId { get; set; }
        public string marketname { get; set; }
        public string Schedule { get; set; }
        public string Address { get; set; }
        public string Products { get; set; }
        public string ZipCode { get; set; }


    }
}