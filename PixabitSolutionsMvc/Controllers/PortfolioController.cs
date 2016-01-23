using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PixabitSolutionsMvc.Controllers
{
    public class PortfolioController : Controller
    {
        //
        // GET: /Portfolio/
        public ActionResult ResponsiveProjects()
        {
            ViewBag.Message = "Our projects";

            return View();
        }

        public ActionResult NotResponsiveProjects()
        {
            ViewBag.Message = "Our projects";

            return View();
        }
	}
}