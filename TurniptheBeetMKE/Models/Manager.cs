using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TurniptheBeetMKE.Models
{
    public class Manager
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string BusinessName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsManager { get; set; }
        public bool HasEvent { get; set; }
        public bool HasSurvey { get; set; }

        [Required]
        public string ManagerCode { get; set; }

    }
}