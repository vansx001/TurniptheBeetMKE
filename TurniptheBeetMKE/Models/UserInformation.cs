using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TurniptheBeetMKE.Models
{
    public class UserInformation
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsManager { get; set; }
        public bool IsVendor { get; set; }
        public bool IsCustomer { get; set; }
        public bool IsSubscribed { get; set; }
        public bool AcceptsOnlineOrder { get; set; }
        public bool SentSurvey { get; set; }
        public bool HasPromotion { get; set; }
        public bool HasEvent { get; set; }
        public bool IsPaid { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}