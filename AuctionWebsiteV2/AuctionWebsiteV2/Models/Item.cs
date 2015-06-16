using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionWebsiteV2.Models
{
    public class Item
    {
        //public Item()
        //{
        //    this.NewBid = new List<Bid>();
        //}
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Condition Condition { get; set; }

        public ICollection<Bid> NewBid { get; set; }

        public decimal CurrentBid { get; set; }

        //public decimal CurrentBid
        //{
        //    get { return 0; }
            
        //}
    }
}