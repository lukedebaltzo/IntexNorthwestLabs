using IntexNorthwestLabs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntexNorthwestLabs.Controllers
{
    public class InvoiceController : Controller
    {
        public static List<Invoice> lstAssay = new List<Invoice>();

        // GET: Invoice
        public ActionResult PastInvoices()
        {
            return View(lstAssay.Find(x => x.PaidStatus == true));
        }
    }
}