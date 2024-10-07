using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TranVanTu_KtraFE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MasterlayOut()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult GiaDen()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GiaoDen()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}