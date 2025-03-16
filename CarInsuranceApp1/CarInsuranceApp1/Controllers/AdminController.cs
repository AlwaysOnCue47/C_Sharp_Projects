using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsuranceApp1.Models; 

namespace CarInsuranceApp1.Controllers
{
    public class AdminController : Controller
    {
        private Entities db = new Entities(); // Connects to your database

        public ActionResult Index()
        {
            var insurees = db.Table1Insurees.ToList(); // Get all customers
            foreach (var insuree in insurees)
            {
                insuree.Quote = InsureePartial.CalculateQuote(insuree);
            }
            return View(insurees);
        }
    }
}