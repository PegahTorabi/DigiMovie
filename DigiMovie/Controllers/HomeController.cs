using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using DigiMovie.Helpers;

namespace DigiMovie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Index")]
        public ActionResult IndexTheme()
        {
            string name = "";
            int ThemeName = Convert.ToInt16(Request.Form["theme"]);
            if (ThemeName == 2)
            {
                name = "Simplex";
            }
            else if (ThemeName == 3)
            {
                name = "Yeti";
            }
            else if (ThemeName == 4)
            {
                name = "Readable";
            }
            else if (ThemeName == 5)
            {
                name = "Darkly";
            }
            else if (ThemeName == 6)
            {
                name = "Cerulean";
            }
            ViewBag.Theme = "~/views/shared/_" + name + "ThemeLayout.cshtml";
            return View();
        }

        [Route("DigiMovie/About Us")]
        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        [ActionName("About")]
        [Route("DigiMovie/About Us")]
        public ActionResult AboutTheme()
        {
            string name = "";
            int ThemeName = Convert.ToInt16(Request.Form["theme"]);
            if (ThemeName == 2)
            {
                name = "Simplex";
            }
            else if (ThemeName == 3)
            {
                name = "Yeti";
            }
            else if (ThemeName == 4)
            {
                name = "Readable";
            }
            else if (ThemeName == 5)
            {
                name = "Darkly";
            }
            else if (ThemeName == 6)
            {
                name = "Cerulean";
            }
            ViewBag.Theme = "~/views/shared/_" + name + "ThemeLayout.cshtml";
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail()
        {
            var message = new MailMessage
            {
                From = Email.GetMailAddress(EmailType.Info),
                Subject = "وب سایت دیجی مووی-قسمت درباره ی ما",
                Body = string.Format("با عرض سلام پیام جدیدی از صفحه ی درباره ی ما وب سایت دیجی مووی دریافت گردید." +
                "<hr>" +
                "نام :  " +
                "{0}<hr>" +
                "ایمیل :  " +
                "{1}<hr>" +
                "موضوع :  " +
                "{2}<hr>" +
                "متن پیام :  " +
                "{3}", Request.Form["name"], Request.Form["email"], Request.Form["subject"], Request.Form["body"]),
                IsBodyHtml = true
            };
            message.To.Add(Email.GetMailName(EmailType.Info));
            var smtp = Email.GetSmtp(EmailType.Info);
            try
            {
                smtp.Send(message); ViewBag.status = 1;
            }
            catch (Exception ex)
            {

                ViewBag.message = 0;
            }
            return View("About");
        }
        [Route("DigiMovie/Contact Us")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        [ActionName("Contact")]
        [Route("DigiMovie/Contact Us")]
        public ActionResult ContactTheme()
        {
            string name = "";
            int ThemeName = Convert.ToInt16(Request.Form["theme"]);
            if (ThemeName == 2)
            {
                name = "Simplex";
            }
            else if (ThemeName == 3)
            {
                name = "Yeti";
            }
            else if (ThemeName == 4)
            {
                name = "Readable";
            }
            else if (ThemeName == 5)
            {
                name = "Darkly";
            }
            else if (ThemeName == 6)
            {
                name = "Cerulean";
            }
            ViewBag.Theme = "~/views/shared/_" + name + "ThemeLayout.cshtml";
            return View();
        }

    }
}