using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day6.Controllers
{
    public class FruitController : Controller
    {
        // GET: Fruit
        [Route("Veggie/Yum")]
        public ActionResult Index()
        {
            return Content("Hello from attribute route!");
        }

        [Route("Veggie/Yum/{id:int}")]
        public ActionResult Details(int id)
        {
            return Content("Fruit Details " + id.ToString());        
        }
    }
}