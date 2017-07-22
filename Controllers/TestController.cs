using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        //public string Test()
        //{
        //    return "It's time to say Wassup Bro!";
        //}
        public ActionResult GetView()
        {
            return View("MyView");
        }
    }
}