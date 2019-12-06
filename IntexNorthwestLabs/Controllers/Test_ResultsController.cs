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
    public class Test_ResultsController : Controller
    {
        private NorthWestLabsContext db = new NorthWestLabsContext();

        // GET: Test_Results
        public ActionResult Index(int iCode)
        {
            var obj = db.Test_Results.Where(x => x.CustomerCode == iCode);
            return View(obj.ToList());
            //return View(db.Test_Results.ToList());
        }

        // GET: Test_Results/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test_Results test_Results = db.Test_Results.Find(id);
            if (test_Results == null)
            {
                return HttpNotFound();
            }
            return View(test_Results);
        }

        // GET: Test_Results/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Test_Results/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssayCode,TestCode,LTNumber,SequenceNumber,AssayName,TestName,CompoundName,TestStatus,TestResultQuantitative,TestResultQualitative,CustomerCode")] Test_Results test_Results)
        {
            if (ModelState.IsValid)
            {
                db.Test_Results.Add(test_Results);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(test_Results);
        }

        // GET: Test_Results/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test_Results test_Results = db.Test_Results.Find(id);
            if (test_Results == null)
            {
                return HttpNotFound();
            }
            return View(test_Results);
        }

        // POST: Test_Results/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssayCode,TestCode,LTNumber,SequenceNumber,AssayName,TestName,CompoundName,TestStatus,TestResultQuantitative,TestResultQualitative,CustomerCode")] Test_Results test_Results)
        {
            if (ModelState.IsValid)
            {
                db.Entry(test_Results).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(test_Results);
        }

        // GET: Test_Results/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test_Results test_Results = db.Test_Results.Find(id);
            if (test_Results == null)
            {
                return HttpNotFound();
            }
            return View(test_Results);
        }

        // POST: Test_Results/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Test_Results test_Results = db.Test_Results.Find(id);
            db.Test_Results.Remove(test_Results);
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

        public ActionResult PendingApproval(int? iCode)
        {

            var obj = db.Test_Results.Where(x => x.CustomerCode == iCode && x.TestStatus == "Pending Additional Testing Approval");
           

            return View(obj.ToList());
        }
    }
}
