using learningmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace learningmvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new Model1();
            var list = db.passwords.ToList();
            System.Diagnostics.Debug.WriteLine(list);
            Convert.ToString(list.ToArray());
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
    }
}