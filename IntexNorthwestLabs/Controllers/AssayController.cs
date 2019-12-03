using IntexNorthwestLabs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntexNorthwestLabs.Controllers
{
    public class AssayController : Controller
    {
        public static List<Assay> lstAssay = new List<Assay>();


        // GET: Assay
        public ActionResult Catalog()
        {
            return View(lstAssay);
        }

        public ActionResult Details(int iCode)
        {
            return View(lstAssay.Find(x => x.AssayCode == iCode));
        }

        
    }
}