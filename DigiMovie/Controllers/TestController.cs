using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DigiMovie.Models;

namespace DigiMovie.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var movie1 = new Movie { Id = 2, Name = "torabi" };
            ViewData["movie"] = movie1;
            var movie2 = new Movie { Id = 3, Name = "pegah" };
            ViewBag.message = movie2;
            return View();
        }
        public ActionResult RowAjaxProcess(string name)
        {
            var user = new { Id = 1, Name = "pegi", Age=25 };
            return Json(user, JsonRequestBehavior.AllowGet);
        }
        public ActionResult AjaxActionLinkProcess()
        {
            System.Threading.Thread.Sleep(8000);
            return Content("WELCOME");
        }
    }
}