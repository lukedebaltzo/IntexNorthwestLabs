using IntexNorthwestLabs.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntexNorthwestLabs.Models;


namespace IntexNorthwestLabs.Controllers
{
    public class Assay_CatalogController : Controller
    {
        private NorthWestLabsContext db = new NorthWestLabsContext();

        // GET: Assay_Catalog
        public ActionResult Index()
        {
            return View(db.Assay_Catalog.ToList());
        }
    }
}