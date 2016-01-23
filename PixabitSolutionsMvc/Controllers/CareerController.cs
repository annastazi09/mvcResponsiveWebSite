using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PixabitSolutionsMvc.Controllers
{
    public class CareerController : Controller
    {
        //
        // GET: /Career/
        public ActionResult DotNetDeveloper()
        {
            return View();
        }

        public ActionResult BusinessAnalyst()
        {
            return View();
        }
	}
}