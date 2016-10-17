using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurniptheBeetMKE.Models
{
    public class MarketViewModel
    {

        public int id { get; set; }

        [Display(Name = "Market Name")]
        public string marketname { get; set; }
        public string Schedule { get; set; }
        public string Address { get; set; }
        public string Products { get; set; }

        [Display(Name = "Zip/Postal Code")]
        public int ZipCode { get; set; }
    }
}