﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetrorailGautengIntranet.Controllers
{
    public class EventsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upcoming()
        {
            return View();
        }

        public ActionResult Archive()
        {
            return View();
        }
	}
}