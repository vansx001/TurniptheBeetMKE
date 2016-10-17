using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TurniptheBeetMKE.Models
{
    public class Vendor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string BusinessName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsVendor { get; set; }
        public bool IsSubscribed { get; set; }
        public bool HasPromotion { get; set; }

        [Required]
        public string VendorCode { get; set; }

         public bool AcceptsOnlineOrder { get; set; }
    }
}