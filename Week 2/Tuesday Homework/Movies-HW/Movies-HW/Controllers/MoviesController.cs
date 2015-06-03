using Movies_HW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies_HW.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var model = new MoviesIndexVM();

            model.Movie.Title = "Star Wars";
            model.Movie.YearReleased = 1990;
            model.Movie.Director = "Lucas";

            return View(model);
        }
    }
}