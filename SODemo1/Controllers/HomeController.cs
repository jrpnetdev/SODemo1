using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SODemo1.Models;

namespace SODemo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string AjaxTester()
        {
            if (Request.IsAjaxRequest())
            {
                return DateTime.Now.ToString();
            }
            else
            {
                return "FAIL";
            }
        }
    }
}