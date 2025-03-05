using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentsMVCapp.Models;

namespace StudentsMVCapp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Jim",
                LastName = "Kirk"
            };

            return View(dayTimeInstructor);
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "William",
                    LastName = "Riker"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Geordie",
                    LastName = "LaForge"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Beverly",
                    LastName = "Crusher"
                }
            };
            return View(instructors);
        }
    }
}