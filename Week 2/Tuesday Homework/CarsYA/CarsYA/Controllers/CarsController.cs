using CarsYA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsYA.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            var model = new CarsVM();

            model.Cars.Make = "Subaru";
            model.Cars.Model = "BRZ";
            model.Cars.Year = 2013;

            return View(model);
        }

        public ActionResult Next()
        {
            var model = new CarsVM();

            model.Cars.Make = "Scion";
            model.Cars.Model = "FRS";
            model.Cars.Year = 2012;

            return View(model);
        }
    }
}