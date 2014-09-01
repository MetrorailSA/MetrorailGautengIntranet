using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetrorailGautengIntranet.Models.ForMe
{
    public class Vacancy
    {

        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string DocName { get; set; }
        
        public Vacancy()
        {

        }

        public Vacancy(string jobtitle, string department, string docname)
        {
            JobTitle = jobtitle;
            Department = department;
            DocName = docname;
        }

        public Vacancy(string[] stringArr)
            : this(stringArr[0], stringArr[1], stringArr[2])
        {
            
        }
    }
}