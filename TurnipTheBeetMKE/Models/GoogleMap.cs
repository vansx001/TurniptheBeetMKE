using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurnipTheBeetMKE.Models
{
    public class GoogleMap
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Current Location")]
        public string CurrentLocation { get; set; }

        public string Destination { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
    