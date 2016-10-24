using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurnipTheBeetMKE.Models
{
    public class Address
    {
        [Key]

        [Display(Name = "Address Id")]
        public int AddressId { get; set; }

        [Display(Name = "Address")]
        public string Street { get; set; }

        [Display(Name = "Apartment No.")]
        public string ApartmentNumber { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        [StringLength(2)]
        public string State { get; set; }

        [Display(Name = "Zip/Postal Code")]
        [StringLength(5)]
        public string ZipCode { get; set; }

        [Required]
        [Phone]
        [DisplayFormat(DataFormatString = "{0:###-###-####}", ApplyFormatInEditMode = true)]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}