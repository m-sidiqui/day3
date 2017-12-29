using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace day3._2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            TempData["siddiqui"] = id;
            TempData.Keep("siddiqui");
            return View();
        }
        public ActionResult ThankYou()
        {
            return View();
        }
    }
}