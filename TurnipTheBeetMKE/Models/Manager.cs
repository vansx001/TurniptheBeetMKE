using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurnipTheBeetMKE.Models
{
    public class Manager
    {
        [Key]
        public int ManagerId { get; set; }
        public string BusinessName { get; set; }
        public bool HasSurvey { get; set; }
        public bool HasEvent { get; set; }
        public bool IsManager { get; set; }
        public string ManagerCode { get; set; }
    }
}