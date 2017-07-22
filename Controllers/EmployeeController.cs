using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_WebApplication1.Models;

namespace MVC_WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ViewResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Pratik";
            emp.LastName = "Soni";

            /* Can use ViewData instead ViewBag
            ViewData["Employee"] = emp;
            return View("MyView");
            */

            ViewBag.Employee = emp;
            return View("MyView");
        }
    }
}