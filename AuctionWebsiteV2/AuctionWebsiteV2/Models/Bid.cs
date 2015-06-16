using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionWebsiteV2.Models
{
    public class Bid
    {
        public int Id { get; set; }

        public string BidderName { get; set; }

        public decimal BidAmount { get; set; }

    }
}