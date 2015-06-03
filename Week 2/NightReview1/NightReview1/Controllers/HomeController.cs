using NightReview1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NightReview1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new Car();
            model.Id = 1;
            model.Year = 2016;
            model.Make = "VW";
            model.Model = "R32";

            return View(model);
        }
    }
}