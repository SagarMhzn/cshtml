using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_assignment.Controllers
{
    public class HomeController : Controller
    {
        // GET: displayHome
        public ActionResult displayHome()
        {
            return View();
        }
    }
}