using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuctionWebsite.Models
{
    public class AuctionDB:DbContext
    {
        public IDbSet<AuctionItem> AuctionItems { get; set; }
    }
}