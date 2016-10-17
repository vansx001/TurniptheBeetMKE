using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TunipTheBeetMKE.Models
{
    public class Market
    {
        [Key]
        public int Id { get; set; }
        public string marketname { get; set; }
        public string Schedule { get; set; }
        public string Address { get; set; }
        public string Products { get; set; }
        public int ZipCode { get; set; }
    }

}