using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnipTheBeetMKE.Models
{
    public class UserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName {
            get {
                return FirstName + " " + LastName;
            }
        }
    }
}