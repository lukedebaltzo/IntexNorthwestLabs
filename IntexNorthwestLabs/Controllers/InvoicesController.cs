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
    public class InvoicesController : Controller
    {
        private NorthWestLabsContext db = new NorthWestLabsContext();

        // GET: Invoices
        public ActionResult Index(int? iCode)
        {
            var obj = db.Invoice.Where(x => x.CustomerCode == iCode);
            return View(obj.ToList());
            //var obj = db.Invoice.ToList();
            //return View(obj);
        }

        // GET: Invoices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invoice invoice = db.Invoice.Find(id);
            if (invoice == null)
            {
                return HttpNotFound();
            }
            return View(invoice);
        }


        // GET: Invoices
        //view Current Invoices
        public ActionResult ViewCurrentInvoices(int? iCode)
        {
            //var obj = db.Invoice.ToList();//.Where(PaidStatus == false);
            //var obj = db.Invoice.Where(x => x.CustomerCode == iCode);
            //return View(obj.ToList());
            var obj = db.Invoice.Where(x => x.PaidStatus == false && x.CustomerCode == iCode);
            return View(obj.ToList());
        }

        /*
        // GET: Invoices/Details/5
        public ActionResult CurrentInvoicesDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

             Invoice invoice = db.Invoice.Find(id);
            if (invoice == null)
            {
                return HttpNotFound();
            }
            return View(invoice);
        }
        */
        public ActionResult PayInvoice(int? id)
        {
            Invoice invoicepay =  db.Invoice.Find(id);

            return View(invoicepay);
        }
    }
}
