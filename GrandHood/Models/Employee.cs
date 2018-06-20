using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrandHood.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        public int CompanyID { get; set; }
        public virtual Company Company{ get; set; }
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }
    }
}