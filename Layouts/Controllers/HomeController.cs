using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layouts.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Route("home")]
        [Route("")]
        public ActionResult Home()
        {
            return View();
        }
        [Route("about")]
        public ActionResult About()
        {
            return View();
        }
        [Route("contact")]
        public ActionResult Contact()
        {
            return View();
        }

        [Route("profile")]
        public ActionResult Profile()
        {
            return View();
        }
    }
}