using GrandHood.DAL;
using GrandHood.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrandHood.Controllers
{
    public class HomeController : Controller
    {
        private GrandHoodContext db = new GrandHoodContext();

        public ActionResult Index()
        {
            var result = from comp in db.Companies
                         join emp in db.Employees on comp.CompanyID equals emp.CompanyID
                         join adr in db.Addresses on emp.AddressID equals adr.AddressID
                         orderby comp.Name
                         select new GrandHoodViewModel { CompanyName = comp.Name, EmployeeFistName = emp.FirstName, EmployeeLastName = emp.LastName, EmployeeAddress = (adr.Number + " " + adr.Street + ", " + adr.City + " " + adr.Country) };

            return View(result.ToList());
        }
    }
}