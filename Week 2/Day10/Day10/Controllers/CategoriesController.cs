using Day10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Day10.Controllers
{
    public class CategoriesController : Controller
    {
        private MoviesDB _db = new MoviesDB();
        // GET: Categories
        public ActionResult Index()
        {
            var categories = _db.Categories.Include(c => c.Movies).ToList();
            return View(categories);
        }
    }
}