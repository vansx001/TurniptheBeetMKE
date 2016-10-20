using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TurnipTheBeetMKE.Models
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }
        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }
        public bool IsSubscribed { get; set; }
        public bool IsVendor { get; set; }

        [Required(ErrorMessage = "The code you entered does not match.")]
        [Display(Name = "Authentication Code")]
        public string VendorCode { get; set; }
        public bool HasPromotion { get; set; }
        public bool AcceptsOnlineOrder { get; set; }

        public List<Customer> Customer { get; set; }
    }
}