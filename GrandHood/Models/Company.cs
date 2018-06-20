using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GrandHood.Models
{
    public class Company
    {
        public int CompanyID { get; set; }
        [Display(Name = "Company name")]
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Display(Name = "Sales revenue")]
        public int SalesRevenue { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}