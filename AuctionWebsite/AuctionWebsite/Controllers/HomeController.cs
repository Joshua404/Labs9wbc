using AuctionWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Migrations;
using System.Data.Entity;

namespace AuctionWebsite.Controllers
{
    public class HomeController : Controller
    {
        private AuctionDB _db = new AuctionDB();

        public ActionResult Index()
        {
            //var auction = _db.AuctionItems.Include(c => c.Auction).ToList();
            var auction = _db.AuctionItems.ToList();
            return View(auction);
        }

        [HttpGet]
        public ActionResult Create()
        {



            return View();
        }


        [HttpPost]
        public ActionResult Create(AuctionItem model)
        {

            _db.AuctionItems.AddOrUpdate(model);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Bid(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Bid(int id, Bid bid)
        {
            if (ModelState.IsValid)
            {
                var bob = (from a in _db.AuctionItems.Include(item => item.Bidcc) where a.Id == id select a).FirstOrDefault();
                bob.Bidcc.Add(bid);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
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
    }
}