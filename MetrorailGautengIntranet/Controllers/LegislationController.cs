using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetrorailGautengIntranet.Controllers
{
    public class LegislationController : Controller
    {
        //
        // GET: /Legislation/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PublicFinanceManagementAct()
        {
            return View();
        }

        public ActionResult BasicConditionsOfEmployment()
        {
            return View();
        }

        public ActionResult EmploymentEquityAct()
        {
            return View();
        }

        public ActionResult LabourRelationsAct()
        {
            return View();
        }

        public ActionResult SkillsDevelopmentAct()
        {
            return View();
        }
	}
}