﻿using System.Web.Mvc;

namespace JargonProject.Controllers
{
    public class HomeController : BaseController
    {    
        public ActionResult Error()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Error(string aspxerrorpath)
        {
            if (!string.IsNullOrWhiteSpace(aspxerrorpath))
                return RedirectToAction("Error");

            return View();
        }

        public ActionResult About()
        {
            return View("About");
        }

        public ActionResult Instructions()
        {
            return View("Instructions");
        }

        public ActionResult Examples()
        {
            return View("Examples");
        }

        public ActionResult Literature()
        {
            return View("Literature");
        }

        public ActionResult Developers()
        {
            return View("Developers");
        }

        public ActionResult HowToCite()
        {
            return View("How to cite");
        }

        public ActionResult ContactUs()
        {
            return View("Contact Us");
        }
    }
}