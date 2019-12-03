using IntexNorthwestLabs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntexNorthwestLabs.Controllers
{
    public class AboutController : Controller
    {
        public static List<Location> lstLocation = new List<Location>();

        // GET: About
        public ActionResult Index()
        {
            ViewBag.space = " ";
            return View();
        }
    }
}