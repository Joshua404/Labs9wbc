using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuctionWebsiteV2.Models
{
    public class ItemDB:DbContext
    {
        public IDbSet<Item> Items { get; set; }

        public IDbSet<Bid> Bids { get; set; }
    }
}