using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACEmployees.Controllers
{
    public class CustomErrorController : Controller
    {
        [HandleError]
        public ActionResult Index()
        {
            return View("Error");
        }

        public ActionResult NotFound()
        {
            return View();
        }
    }
}