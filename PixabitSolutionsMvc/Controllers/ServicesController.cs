using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PixabitSolutionsMvc.Controllers
{
    public class ServicesController : Controller
    {
        //
        // GET: /Services/
        public ActionResult SoftwareDevelopment()
        {
            ViewBag.Message = "Software development";

            return View();
        }

        public ActionResult DotNetDevelopment()
        {
            ViewBag.Message = ".Net development";

            return View();
        }

        public ActionResult WebDevelopment()
        {
            ViewBag.Message = "Web development";

            return View();
        }

        
	}
}