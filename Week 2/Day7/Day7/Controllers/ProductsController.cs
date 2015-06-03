using Day7.Models;
using Day7.Views.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day7.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            //var products = new List<Product> { 
            //    new Product {Name="Milk", Price=3.22m},
            //    new Product {Name="Cheese", Price=32.22m}
            //};


            //var vm = new IndexVM 
            //{ 
            //    Products = products
            //};


            //ViewBag.Products = products;
            //ViewData["products"] = products;
            return View();
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            var categories = new List<Category> 
            { 
                new Category {Id=1, Name="Electronics"},
                new Category {Id=2, Name="Beverages"}
            
            };

            var vm = new CreateVM
            {
                Categories = new SelectList(categories, "Id", "Name")
            };

            return View(vm);
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(CreateVM vm)
        {
           //cow.Val3 = cow.Val1 + cow.Val2;

            //return View(cow);
           return RedirectToAction("Index");
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
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

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
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
