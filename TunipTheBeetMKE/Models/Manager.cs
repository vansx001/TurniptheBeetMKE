using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TunipTheBeetMKE.Models
{
    public class Manager
    {
        [Key]
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public bool HasSurvey { get; set; }
        public bool HasEvent { get; set; }
        public bool IsManager { get; set; }
        public string ManagerCode { get; set; }
        [ForeignKey("Vendor")]
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }

        [ForeignKey("Market")]
        public int MarketId { get; set; }
        public Market Market { get; set; }
    }
}