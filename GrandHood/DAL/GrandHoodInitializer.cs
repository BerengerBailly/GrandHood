using GrandHood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrandHood.DAL
{
    public class GrandHoodInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GrandHoodContext>
    {
        protected override void Seed(GrandHoodContext context)
        {

            var addresses = new List<Address>
            {
                new Address{Number=28,Street="5th Avenue",City="NY",Country="USA"},
                new Address{Number=27,Street="Brooklyn",City="NY",Country="USA"},
                new Address{Number=38,Street="37th",City="NY",Country="USA"},
                new Address{Number=98,Street="Eagle",City="NY",Country="USA"},
                new Address{Number=1,Street="Sherbrooke",City="Montreal",Country="Canada"},
                new Address{Number=2,Street="Saint-Laurent",City="Montreal",Country="Canada"},
                new Address{Number=42,Street="Rivard",City="Montreal",Country="Canada"},
                new Address{Number=96,Street="Mont-Royal",City="Montreal",Country="Canada"},
                new Address{Number=56,Street="Vesterbrogade",City="Copenhagen",Country="Denmark"},
                new Address{Number=24,Street="Frederiksberg Allée",City="Copenhagen",Country="Denmark"},
                new Address{Number=24,Street="Agade",City="Copenhagen",Country="Denmark"},
                new Address{Number=24,Street="Carlsberg",City="Copenhagen",Country="Denmark"},
                new Address{Number=51,Street="Henon",City="Lyon",Country="France"},
                new Address{Number=51,Street="Dugesclin",City="Lyon",Country="France"}
            };
            addresses.ForEach(s => context.Addresses.Add(s));
            context.SaveChanges();

            var companies = new List<Company>
            {
                new Company{Name="Microsoft",SalesRevenue=9900294/*,AddressID=1*/},
                new Company{Name="Eudonet",SalesRevenue=9900294/*,AddressID=5*/},
                new Company{Name="Maersk",SalesRevenue=9900294/*,AddressID=9*/},
                new Company{Name="Sopra",SalesRevenue=9900294/*,AddressID=14*/},

            };
            companies.ForEach(s => context.Companies.Add(s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee{FirstName="John",LastName="Doe",CompanyID=1,AddressID=2},
                new Employee{FirstName="Marc",LastName="Dutrou",CompanyID=1,AddressID=3},
                new Employee{FirstName="Jack",LastName="TheReaper",CompanyID=1,AddressID=4},
                new Employee{FirstName="Mary",LastName="Me",CompanyID=2,AddressID=6},
                new Employee{FirstName="Isabelle",LastName="AlesYeuxBleus",CompanyID=2,AddressID=7},
                new Employee{FirstName="Josh",LastName="Ua",CompanyID=2,AddressID=8},
                new Employee{FirstName="Anne",LastName="Franck",CompanyID=3,AddressID=10},
                new Employee{FirstName="Celine",LastName="Dion",CompanyID=3,AddressID=11},
                new Employee{FirstName="Chris",LastName="Hemsworth",CompanyID=3,AddressID=12},
                new Employee{FirstName="Camille",LastName="Lafont",CompanyID=4,AddressID=13},
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
            
        }
    }
}