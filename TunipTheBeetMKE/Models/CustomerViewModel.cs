using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TunipTheBeetMKE.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Customer")]
        public bool IsCustomer { get; set; }

        [Display(Name = "Survey")]
        public bool HasSurvey { get; set; }
        [Display(Name = "Subscribe")]
        public bool IsSubscribed { get; set; }
    }
}