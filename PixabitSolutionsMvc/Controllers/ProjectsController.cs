using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PixabitSolutionsMvc.Controllers
{
    public class ProjectsController : Controller
    {
        //
        // GET: /Projects/
        public ActionResult OurCustomers()
        {
            ViewBag.Message = "Our customers";

            return View();
        }
	}
}