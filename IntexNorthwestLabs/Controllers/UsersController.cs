using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using IntexNorthwestLabs.DAL;
using IntexNorthwestLabs.Models;

namespace IntexNorthwestLabs.Controllers
{
    public class UsersController : Controller
    {
        private NorthWestLabsContext db = new NorthWestLabsContext();


        // GET: Users
        public ActionResult Index()
        {
            return View(db.User.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.User.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create(int? iCode)
        {
            ViewBag.code = iCode;
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserCode,CustomerCode,UserName,UserPassword,UserFirstName,UserLastName,UserEmail")] User user, int iCode)
        {
            if (ModelState.IsValid)
            {
                user.CustomerCode = iCode;
                
                db.User.Add(user);
                db.SaveChanges();
                //return RedirectToAction("CreateLogIn", new { iCode = user.CustomerCode });
                return RedirectToAction("CustomerPortal", "Customers", new { id = user.CustomerCode });
            }

            return View(user);
        }

        public ActionResult CreateLogIn(int iCode)
        {
            var obj = db.User.Where(x => x.CustomerCode == iCode);
            return View(obj.ToList());
            //return View();
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.User.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserCode,CustomerCode,UserName,UserPassword,UserFirstName,UserLastName,UserEmail")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.User.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            User user = db.User.Find(id);
            db.User.Remove(user);
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

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String userName = form["User Name"].ToString();
            String password = form["Password"].ToString();
            /* User fakehomie = new User();
             fakehomie.UserCode = 1000;
             fakehomie.UserEmail = "tester@test.com";
             fakehomie.UserFirstName = "Al";
             fakehomie.UserLastName = "Ir";
             fakehomie.UserName = "alir";
             fakehomie.UserPassword = "pass";
             fakehomie.CustomerCode = 1000;*/

            //User obj = /*db.User.DefaultIfEmpty(fakehomie).First(x => x.UserName == userName);*/ db.User.FirstOrDefault(x => x.UserName == userName);
            //if ((db.User.FirstOrDefault(x => x.UserName == userName) == false )
            //User obj = db.User.FirstOrDefault(x => x.UserName == userName);
            string checkCode = db.User.FirstOrDefault(x => x.UserName == userName)?.UserName;
            if (checkCode != null)
            {
                User obj = db.User.FirstOrDefault(x => x.UserName == userName);


                String authUserName = obj.UserName;
                String authPassword = obj.UserPassword;

                    if (string.Equals(userName, authUserName) && (string.Equals(password, authPassword)))
                    {
                        FormsAuthentication.SetAuthCookie(userName, rememberMe);

                        return RedirectToAction("CustomerPortal", "Customers", new { id = obj.CustomerCode });
                    }
                    else

                    {
                    ViewBag.error = "Please enter a valid username and password";
                       return View();
                    }
            }
            else

            {
                ViewBag.error = "Please enter a valid username and password";
                return View();
            }
        }

        public ActionResult ShowAllUsers(int iCode)
        {
            //List<User> UserList = new List<User>();
            var obj = db.User.Where(x => x.CustomerCode == iCode);
            return View(obj.ToList());
            //User allusers = db.User.Where(x => x.CustomerCode == iCode);
            //return View();
        }


    }
}
