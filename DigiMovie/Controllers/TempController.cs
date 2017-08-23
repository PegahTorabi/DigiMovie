using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigiMovie.Controllers
{
    public class TempController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult IndexSent(string firstName, 
            string lastName ,
            string password ,
            string homeAddress,
            string officeAddress,
            string phoneNumber,
            bool agreement,
            int gender,
            int city,
            int fruits)
        {
            return View();
        }

    }
}