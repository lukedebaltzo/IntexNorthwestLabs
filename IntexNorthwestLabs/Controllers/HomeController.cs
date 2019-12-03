using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace IntexNorthwestLabs.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult CustomerHome()
        {
            return View();
        }

        public ActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(string firstname, string lastname, string company, string email, string subject, string message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("intexNorthwestLabs@gmail.com", "Northwest Labs");
                    var receiverEmail = new MailAddress("intexNorthwestLabs@gmail.com", "Northwest Labs");
                    var password = "DreamTeam2-3";
                    var sub = subject;
                    var body = message;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = "Contact Form for " + firstname + " " + lastname,
                        Body = "Requester: " + firstname + " " + lastname + "\n" +
                                "Company: " + company + "\n" +
                                "Email: " + email + "\n" +
                                "Subject: " + subject + "\n" +
                                "Message: " + message + "\n"

                    })
                    {
                        smtp.Send(mess);
                    }
                    return RedirectToAction("EmailSent");
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Some Error";
            }
            return View();
        }

        public ActionResult EmailSent()
        {
            return View();
        }



        public ActionResult RequestQuote()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RequestQuote(string username, string email, string message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("intexNorthwestLabs@gmail.com", "Northwest Labs");
                    var receiverEmail = new MailAddress("intexNorthwestLabs@gmail.com", "Northwest Labs");
                    var password = "DreamTeam2-3";
                    var sub = "Quote Request for user " + username;
                    var body = message;

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = "Quote Request for user " + username,
                        Body = "Requester: " + username + "\n" +
                                "Email: " + email + "\n" +
                                "Message: " + message + "\n"

                    })
                    {
                        smtp.Send(mess);
                    }
                    return RedirectToAction("EmailSent");
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Some Error";
            }
            return View();
        }


    }
}
