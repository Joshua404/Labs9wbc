using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionWebsite.Models
{
    public class AuctionItem
    {
        public AuctionItem()
        {
            this.Bidcc = new List<Bid>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Condition Condition { get; set; }

        public ICollection<Bid> Bidcc { get; set; }

        public decimal MyBid
        {
            get { return 0; }
            
        }

    }
}