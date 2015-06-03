using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsYA.Controllers
{
    public class AddCarsController : Controller
    {
        // GET: AddCars
        public ActionResult Index()
        {
            return View();
        }

        // GET: AddCars/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddCars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddCars/Create
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

        // GET: AddCars/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddCars/Edit/5
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

        // GET: AddCars/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddCars/Delete/5
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
