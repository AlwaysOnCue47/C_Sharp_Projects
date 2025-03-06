using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsuranceApp1.Models;

namespace CarInsuranceApp1.Controllers
{
    public class Table1InsureeController : Controller
    {
        private Entities db = new Entities();

        // GET: Table1Insuree
        public ActionResult Index()
        {
            return View(db.Table1Insurees.ToList());
        }

        // GET: Table1Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table1Insurees table1Insurees = db.Table1Insurees.Find(id);
            if (table1Insurees == null)
            {
                return HttpNotFound();
            }
            return View(table1Insurees);
        }

        // GET: Table1Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table1Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table1Insurees table1Insurees)
        {
            if (ModelState.IsValid)
            {
                db.Table1Insurees.Add(table1Insurees);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table1Insurees);
        }

        // GET: Table1Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table1Insurees table1Insurees = db.Table1Insurees.Find(id);
            if (table1Insurees == null)
            {
                return HttpNotFound();
            }
            return View(table1Insurees);
        }

        // POST: Table1Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table1Insurees table1Insurees)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table1Insurees).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table1Insurees);
        }

        // GET: Table1Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table1Insurees table1Insurees = db.Table1Insurees.Find(id);
            if (table1Insurees == null)
            {
                return HttpNotFound();
            }
            return View(table1Insurees);
        }

        // POST: Table1Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table1Insurees table1Insurees = db.Table1Insurees.Find(id);
            db.Table1Insurees.Remove(table1Insurees);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
