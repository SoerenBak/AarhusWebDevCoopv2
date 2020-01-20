using AarhusWebDevCoopv2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using System.Net.Mail;
using Umbraco.Core.Models;


namespace AarhusWebDevCoopv2.Controllers
{
    public class ContactFormSurfaceController : SurfaceController
    {
        // GET: ContactFormSurface
        public ActionResult Index()
        {
            return PartialView("ContactForm", new ContactForm());
        }

        [HttpPost]
        public ActionResult HandleFormSubmit(ContactForm model)
        {

            if (!ModelState.IsValid) { return RedirectToCurrentUmbracoPage(); }

            MailMessage message = new MailMessage();
            message.To.Add("fff56k@gmail.com");
            message.Subject = model.Subject;
            message.From = new MailAddress(model.Email, model.Name);
            message.Body = model.Message;

            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network; smtp.UseDefaultCredentials = false; smtp.EnableSsl = true; smtp.Host = "smtp.gmail.com"; smtp.Port = 587; smtp.Credentials = new System.Net.NetworkCredential("fff56k@gmail.com", "password");        // send mail    smtp.Send(message); } 

            }

            TempData["success"] = true;
        }

    }
}