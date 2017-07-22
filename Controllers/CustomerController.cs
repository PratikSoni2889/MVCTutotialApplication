using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WebApplication1.Controllers
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string CustLocation { get; set; }
    }

    public class CustomerController : Controller
    {
        public Customer GetCustomer()
        {
            Customer CustObject = new Customer();
            CustObject.CustomerName = "Pratik";
            CustObject.CustLocation = "Valsad";
            //PrintCustomer(CustObject);
            return CustObject;
        }

        //Below method will not be exposed to the view as [NonAction] is added to it.
        [NonAction]
        public void PrintCustomer(Customer custObj)
        {
            Console.WriteLine(custObj.CustomerName + " is from " + custObj.CustLocation);
        }
    }
}