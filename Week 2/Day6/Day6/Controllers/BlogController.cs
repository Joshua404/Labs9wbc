using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day6.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult GetEntryById(int entryId)
        {
            return Content("You requested the blog post for the ID " + entryId.ToString());
        }

        public ActionResult GetEntryByDate(DateTime entryDate)
        {
            return Content("You requested the blog post for the Date " + entryDate.ToLongDateString());
        }
    }
}