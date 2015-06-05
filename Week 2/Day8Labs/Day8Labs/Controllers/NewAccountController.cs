using Day8Labs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day8Labs.Controllers
{
    public class NewAccountController : Controller
    {
        // GET: NewAccount
        public ActionResult Index()
        {
            return View();
        }

        // GET: NewAccount/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult RegisterBetter()
        {


            return View();
            //return Json(username.ToLower() == "stephen" ? false : true);
        }

        [HttpPost]
        public ActionResult RegisterBetter(NewAccountVM model)
        {
            return View();
        }

        // GET: NewAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewAccount/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NewAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewAccount/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NewAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewAccount/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
