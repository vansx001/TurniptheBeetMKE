using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TunipTheBeetMKE.Models
{
    public class Vendor
    {
        [Key]
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public bool IsSubscribed { get; set; }
        public bool IsVendor { get; set; }
        public string VendorCode { get; set; }
        public bool HasPromotion { get; set; }
        public bool AcceptsOnlineOrder { get; set; }
        [ForeignKey("Manager")]
        public int ManagerId { get; set; }
        public Manager Manager { get; set; }

        [ForeignKey("Market")]
        public int MarketId { get; set; }
        public Market Market { get; set; }

    }
}