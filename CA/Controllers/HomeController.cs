using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CA.Controllers
{
    enum Language
    {
        English,
        Greek
    };

    public class HomeController : Controller
    {
        internal Language Language { get; set; } = Language.English;
        
        public ActionResult Index()
        {
            ViewBag.Lang = Language;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About us";

            return View();
        }

        public ActionResult Publications()
        {
            ViewBag.Message = "Publications";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(FormCollection form)
        {
            string userName = Request.Form["userName"];
            string userEmail = Request.Form["userEmail"];
            string userComment = Request.Form["userComment"];
          
            sendEmail(userName, userEmail, userComment);
                
            ViewBag.Message = "Your message has been sent";
            return View();
        }

        public ActionResult DownloadPDF()
        {
            return File("~/Content/2018.pdf", "application/pdf");
        }



        private void sendEmail(string userName, string userEmail, string userComment) {
            try
            {
                new SmtpClient
                {
                    Host = "mail.georgebaras.com",
                    Port = 8889,
                    EnableSsl = true,
                    Timeout = 10000,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("george@georgebaras.com", "")
                }.Send(new MailMessage { From = new MailAddress("george@georgebaras.com", "CA-Hellas"), To = { "george@georgebaras.com" }, Subject = userName + " " + userEmail, Body = userComment, BodyEncoding = Encoding.UTF8 });

            }
            catch
            {
            }
            finally {

            }

        }

        public ActionResult Services()
        {
            ViewBag.Message = "Services";

            return View();
        }

        public ActionResult AuditServices()
        {
            ViewBag.Message = "Audit Services";
            ViewBag.Tab = "AuditServices";
            return View("Services");
        }

        public ActionResult ConsultingServices()
        {
            ViewBag.Message = "Consulting Services";
            ViewBag.Tab = "ConsultingServices";
            return View("Services");
        }

        public ActionResult TaxationServices()
        {
            ViewBag.Message = "Taxation Services";
            ViewBag.Tab = "TaxationServices";
            return View("Services");
        }

        public ActionResult AccountingServices()
        {
            ViewBag.Message = "Accounting Services";
            ViewBag.Tab = "AccountingServices";
            return View("Services");
        }

        public ActionResult InternalServices()
        {
            ViewBag.Message = "Internal Services";
            ViewBag.Tab = "InternalServices";
            return View("Services");
        }

        public ActionResult ELE()
        {
            ViewBag.Message = "ELE";

            return View();
        }
    }
}