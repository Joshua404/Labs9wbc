using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day8.Controllers
{
    public class BannerAdController : Controller
    {
        [ChildActionOnly]
        // GET: BannerAd
        public ActionResult GetAd()
        {
            var adText = "Buy Coffee!";
            if (DateTime.Now.Hour > 12)
            {
                adText = "Buy Cody a Beer!";
            }
            return PartialView("_BannerAd", adText);
        }
    }
}