using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurnipTheBeetMKE.Models
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }
        public string BusinessName { get; set; }
        public bool IsSubscribed { get; set; }
        public bool IsVendor { get; set; }
        public string VendorCode { get; set; }
        public bool HasPromotion { get; set; }
        public bool AcceptsOnlineOrder { get; set; }
    }
}