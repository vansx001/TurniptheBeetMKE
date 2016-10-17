﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TunipTheBeetMKE.Models
{
    public class ManagerViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Business Name must be at least 1 character.", MinimumLength = 1)]
        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }

        [Display(Name = "Survey")]
        public bool HasSurvey { get; set; }
        [Display(Name = "Event")]
        public bool HasEvent { get; set; }


        [Display(Name = "Manager")]
        public bool IsManager { get; set; }

        [Required]
        [Display(Name = "Manager Code")]
        public string ManagerCode { get; set; }

    }
}