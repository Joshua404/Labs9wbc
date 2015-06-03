using NIghtReview2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NIghtReview2.Controllers
{
    public class TodoController : Controller
    {
        // GET: Todo
        public ActionResult Index()
        {
            var model = new TodoVM();

            //model.Todo = new Todo();
            model.Todo.Id = 0;
            model.Todo.Title = "Crazy Stuff List";
            model.Todo.Info = "Go and Do Some really crazy stuff and then have some pizza :) !!!";


            return View(model);
        }
    }
}