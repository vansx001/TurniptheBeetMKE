﻿using System;
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

        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }

        [Display(Name = "Address")]
        public string Street { get; set; }

        [Display(Name = "Apartment No.")]
        public string ApartmentNumber { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "State")]
        [StringLength(2)]
        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip/Postal Code")]
        public int ZipCode { get; set; }
    }
}