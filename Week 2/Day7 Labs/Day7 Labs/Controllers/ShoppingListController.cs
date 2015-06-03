using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day7_Labs.Controllers
{
    public class ShoppingListController : Controller
    {
        // GET: ShoppingList
        public ActionResult Index()
        {
            var products = new string[] { 
                new string {Name="Milk", Price=3.22m},
                new Product {Name="Cheese", Price=32.22m}
            };


            var vm = new IndexVM
            {
                Products = products
            };
            return View();
        }

        // GET: ShoppingList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShoppingList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoppingList/Create
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

        // GET: ShoppingList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShoppingList/Edit/5
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

        // GET: ShoppingList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShoppingList/Delete/5
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
