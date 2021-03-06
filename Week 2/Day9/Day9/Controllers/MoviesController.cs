﻿using Day9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day9.Controllers
{
    public class MoviesController : Controller
    {

        private MoviesDB _db = new MoviesDB();


        // GET: Movies
        public ActionResult Index()
        {
            var movies = from m in _db.Movies select m;
            return View(movies.ToList());
        }

        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {
            var original = _db.Movies.Find(id);

            return View(original);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid) {
                _db.Movies.Add(movie);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {
            var original = _db.Movies.Find(id);
            return View(original);
        }

        // POST: Movies/Edit/5
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid) {
                var original = _db.Movies.Find(movie.Id);
                original.Title = movie.Title;
                original.Director = movie.Director;
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

                return View();
            
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
            var original = _db.Movies.Find(id);
            return View(original);
        }

        // POST: Movies/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete2(int id)
        {
            var original = _db.Movies.Find(id);
            _db.Movies.Remove(original);
            _db.SaveChanges();
            
             return RedirectToAction("Index");
            
        }
    }
}

        