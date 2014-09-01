using MetrorailGautengIntranet.Models.ForMe;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetrorailGautengIntranet.Controllers
{
    public class ForMeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Benefits()
        {
            return View();
        }

        public ActionResult InterestingLinks()
        {
            return View();
        }

        public ActionResult Vacancies()
        {
            List<Vacancy> vacancies = ReadVacancies();

            return View(vacancies);
        }

        private List<Vacancy> ReadVacancies()
        {
            List<Vacancy> vacancies = new List<Vacancy>();
            try
            {
                string path = HttpContext.Server.MapPath("~/Content/Docs/ForMe/Vacancies/vacancies.csv");
                
                var reader = new StreamReader(System.IO.File.OpenRead(path));
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string[] values = line.Split(';');
                    Vacancy vacancy = new Vacancy(values[0], values[1], HttpUtility.UrlPathEncode(values[2]));
                    vacancies.Add(vacancy);
                }
                reader.Close();
                
            }
            catch (Exception ex)
            {
                vacancies.Add(new Vacancy() { JobTitle = "Wrong file format: vacancies.csv", Department = ex.Message});
            }
            return vacancies;
        }

        public ActionResult WellnessAndLifestyle()
        {
            return View();
        }

        public ActionResult Food()
        {
            return View();
        }

        public ActionResult WellnessSmoking()
        {
            return View();
        }

        public ActionResult WellnessStress()
        {
            return View();
        }

        public ActionResult WellnessAlcohol()
        {
            return View();
        }

        public ActionResult WellnessArticles()
        {
            return View();
        }

    }
}
