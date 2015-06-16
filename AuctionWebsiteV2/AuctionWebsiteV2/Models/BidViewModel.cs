using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionWebsiteV2.Models
{
    public class BidViewModel
    {
        public Bid Bid { get; set; }

        public Item Item { get; set; }


        public BidViewModel()
        {
            this.Bid = new Bid();
            this.Item = new Item();
        }
    }

    
}