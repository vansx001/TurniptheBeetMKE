using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurniptheBeetMKE.Models
{
    public class VendorViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Business Name must be at least 1 character.", MinimumLength = 1)]
        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }

        [Display(Name = "Vendor")]
        public bool IsVendor { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Subscribed")]
        public bool IsSubscribed { get; set; }

        [Display(Name = "Promotion")]
        public bool HasPromotion { get; set; }

        [Required]
        [Display(Name = "Vendor Code")]
        public string VendorCode { get; set; }

        [Display(Name = "Accepts Online Order(s)")]
        public bool AcceptsOnlineOrder { get; set; }
    }
}