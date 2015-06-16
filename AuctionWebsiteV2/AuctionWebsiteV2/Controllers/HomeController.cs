using AuctionWebsiteV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Migrations;
using System.Data.Entity;

namespace AuctionWebsiteV2.Controllers
{
    public class HomeController : Controller
    {
        private ItemDB _db = new ItemDB();
        //private Item _da = new NewBid();

        // GET: Default
        public ActionResult Index()
        {
            var auction = _db.Items.ToList();
            return View(auction);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       
        // GET: Default/Details/5
        public ActionResult Details(int id)
        {
            var model = _db.Items.Include(i => i.NewBid).Where(i => i.Id == id).FirstOrDefault();
            return View(model);
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        public ActionResult Create(Item model)
        {
            _db.Items.AddOrUpdate(model);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Bid(int id)
        {
            var model = new BidViewModel();

            model.Item = _db.Items.Where(i => i.Id == id).FirstOrDefault();
            model.Bid.BidAmount = model.Item.CurrentBid + 5m;
            return View(model);
        }

        [HttpPost]
        //public ActionResult Bid(int id, Bid bid)
        public ActionResult Bid(int id, BidViewModel model)
            
        {
            //model.Item.NewBid = new List<Bid>();
            //model.Item.NewBid.Add(model.Bid);
            //model.Item.CurrentBid = model.Bid.BidAmount;

            //_db.Items.AddOrUpdate(model.Item);
            if (ModelState.IsValid)
            {
            var originalItem = _db.Items.Where(i => i.Id == id).FirstOrDefault();
            originalItem.CurrentBid = model.Bid.BidAmount;
            _db.SaveChanges();

            
                var bob = (from a in _db.Items.Include(item => item.NewBid) where a.Id == id select a).FirstOrDefault();
                bob.NewBid.Add(model.Bid);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        //// GET: Default/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Default/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            var original = _db.Items.Find(id);
            return View(original);
        }

        // POST: Default/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var original = _db.Items.Find(id);
            _db.Items.Remove(original);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}