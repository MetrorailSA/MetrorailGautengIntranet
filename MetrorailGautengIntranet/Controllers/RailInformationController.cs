using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetrorailGautengIntranet.Controllers
{
    public class RailInformationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TrainTimeTable()
        {
            return View();
        }

        public ActionResult TrainRoutes()
        {
            return View();
        }
	}
}