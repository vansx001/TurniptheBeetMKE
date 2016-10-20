using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TurnipTheBeetMKE.Models
{
    public class Manager
    {
        [Key]
        public int ManagerId { get; set; }
        [Display(Name = "Farmers Market Name")]
        public string BusinessName { get; set; }
        public bool HasSurvey { get; set; }
        public bool HasEvent { get; set; }
        public bool IsManager { get; set; }

        [Required(ErrorMessage = "The code you entered does not match.")]
        [Display(Name ="Authentication Code")]
        public string ManagerCode { get; set; }

        [ForeignKey("Vendor")]
        public int? VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}