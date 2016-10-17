using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurniptheBeetMKE.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Customer")]
        public bool IsCustomer { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Survey")]
        public bool HasSurvey { get; set; }

        [Display(Name = "Subscribed")]
        public bool IsSubscribed { get; set; }
    }
}