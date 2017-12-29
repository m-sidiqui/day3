using day3._2.ViewModel;
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

        public ActionResult GetDetails()
        {
            EmployeeDeptViewModel myVariable = new EmployeeDeptViewModel()
            {
                firstName = "Musaddiq", lastName = "Siddiqui", deptId = 2, deptName = "Financial Services"
        };
            return View(myVariable);
        }
    }
}