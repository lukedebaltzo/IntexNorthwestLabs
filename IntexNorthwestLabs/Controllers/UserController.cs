using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntexNorthwestLabs.Controllers
{
    public class UserController : Controller
    {
        //this is a controller for checking the authentication of a user
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
    }
}