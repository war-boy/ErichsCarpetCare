using System;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;
using ErichsCarpetCare.UI.MVC.Models;

namespace ErichsCarpetCare.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Contact(ContactViewModel cvm)
        {


            //Keeps the information the user entered if the form fails to send
            if (!ModelState.IsValid)
            {
                return View(cvm);
            }

            if (ModelState.IsValid)
            {
                string body = $"You recieved a service request from {cvm.Email}:<br />" +

                    $"Name: {cvm.FullName}<br/>" +

                    $"Address: {cvm.Address}, {cvm.ZipCode}<br/>" +

                     $"Commercial or Residential: { cvm.IsCommercial}<br/>" +

                    $"Email: {cvm.Email}<br/>" +

                    $"Phone Number: {cvm.Phone} <br/>" +

                   $"Requested Date: {cvm.RequestedDate:MMM/dd/yyyy} <br/>" +

                    $"Referral: {cvm.Referral} <br/>" +

                    $"Referral Source: {cvm.ReferralSource} <br/>" +

                $"Requested Services: " + (cvm.Carpet ? "Carpet " : "") + (cvm.Tile ? "Tile " : "") + (cvm.Upholstery ? "Upholstery " : "") + (cvm.Rug ? "Rug " : "") + (cvm.Other ? "Other " : "") + "<br />" +

                    $"Additional Services: " + (cvm.Odor ? "Odor " : "") + (cvm.CarpetProtector ? "Carpet Protector " : "") + (cvm.AntiAllergin ? "Anti-Allergin " : "") + "<br />";

                MailMessage m = new MailMessage("admin@erichscarpetcare.com", "erichscarpetcare@gmail.com, *Omitted*", $"{cvm.FullName} Service Request", body);
                m.IsBodyHtml = true;
                m.Priority = MailPriority.High;
                m.ReplyToList.Add(cvm.Email);
                SmtpClient client = new SmtpClient("*Omitted*");
                client.Credentials = new NetworkCredential("admin@erichscarpetcare.com", "*Omitted*");
                client.Port = 8889;

                try
                {
                    client.Send(m);
                }
                catch (Exception e)
                {
                    ViewBag.CustomerMessage = $"We're sorry your request could not be completed at this time. Please try again later.<br/>Error Message:<br/>{e.StackTrace}";
                    return View(cvm);
                }
                return View("EmailConfirmation", cvm);

            }
            return View(cvm);

        }

        [HttpGet]
        public ActionResult CarpetCleaning()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TileAndGrout()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Upholstery()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AreaRug()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Services()
        {
            return View();
        }

        [HttpGet]
        public ActionResult FAQ()
        {
            return View();
        }
    }
}
