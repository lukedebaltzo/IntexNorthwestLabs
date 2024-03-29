﻿using Dapper;
using IntexNorthwestLabs.DAL;
using IntexNorthwestLabs.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace IntexNorthwestLabs.Controllers
{
    public class HomeController : Controller
    {
        private NorthWestLabsContext db = new NorthWestLabsContext();
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
        public ActionResult RequestQuote(string assay, string compound, string weight)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("intexNorthwestLabs@gmail.com", "Northwest Labs");
                    var receiverEmail = new MailAddress("intexNorthwestLabs@gmail.com", "Northwest Labs");
                    var password = "DreamTeam2-3";
                    var sub = "Quote Request";
                    var body = assay + " for " + compound + ", which weights " + weight;

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
                        Subject = "Quote Request",
                        Body = assay + " for " + compound + ", which weights " + weight

                })
                    {
                        smtp.Send(mess);
                    }
                    return RedirectToAction("EmailSent");
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Error, please try again";
            }
            return View();
        }

        /*
        //GET api/aircraft
        [HttpGet]
        public async Task<IEnumerable<Assay>> Get(string model)
        {
            IEnumerable<Assay> AssayCatalog;

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                AssayCatalog = await connection.QueryAsync<Assay>("Assay_Catalog",
                                new { Model = model },
                                commandType: CommandType.StoredProcedure);
            }
            return AssayCatalog;
        }
        */

    }
}
