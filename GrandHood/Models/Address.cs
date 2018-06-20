using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GrandHood.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        [Display(Name = "Address")]
        public string CompleteAdress
        {
            get
            {
                return String.Concat(Number, " ", Street, ", ", City, " ", Country);
            }
        }
    }
}