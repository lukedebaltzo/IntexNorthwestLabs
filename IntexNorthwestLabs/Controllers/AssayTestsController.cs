using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IntexNorthwestLabs.DAL;
using IntexNorthwestLabs.Models;

namespace IntexNorthwestLabs.Controllers
{
    public class AssayTestsController : Controller
    {
        private NorthWestLabsContext db = new NorthWestLabsContext();

        // GET: AssayTests
        public ActionResult Index()
        {
            return View(db.AssayTest.ToList());
        }

        // GET: AssayTests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssayTest assayTest = db.AssayTest.Find(id);
            if (assayTest == null)
            {
                return HttpNotFound();
            }
            return View(assayTest);
        }

        // GET: AssayTests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AssayTests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssayCode,TestCode,LTNumber,SequenceNumber,TestStatus,TestResultQuantitative,TestResultQualitative")] AssayTest assayTest)
        {
            if (ModelState.IsValid)
            {
                db.AssayTest.Add(assayTest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(assayTest);
        }

        // GET: AssayTests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssayTest assayTest = db.AssayTest.Find(id);
            if (assayTest == null)
            {
                return HttpNotFound();
            }
            return View(assayTest);
        }

        // POST: AssayTests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssayCode,TestCode,LTNumber,SequenceNumber,TestStatus,TestResultQuantitative,TestResultQualitative")] AssayTest assayTest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assayTest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assayTest);
        }

        // GET: AssayTests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssayTest assayTest = db.AssayTest.Find(id);
            if (assayTest == null)
            {
                return HttpNotFound();
            }
            return View(assayTest);
        }

        // POST: AssayTests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AssayTest assayTest = db.AssayTest.Find(id);
            db.AssayTest.Remove(assayTest);
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
