using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TunipTheBeetMKE.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public bool IsCustomer { get; set; }
        public bool HasSurvey { get; set; }
        public bool IsSubscribed { get; set; }

        [ForeignKey("ApplicationUser")]
        public int UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("Vendor")]
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }

        [ForeignKey("Market")]
        public int MarketId { get; set; }
        public Market Market { get; set; }
    }
}