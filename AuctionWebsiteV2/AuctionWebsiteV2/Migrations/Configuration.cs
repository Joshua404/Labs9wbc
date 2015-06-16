namespace AuctionWebsiteV2.Migrations
{
    using AuctionWebsiteV2.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AuctionWebsiteV2.Models.ItemDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AuctionWebsiteV2.Models.ItemDB";
        }

        protected override void Seed(AuctionWebsiteV2.Models.ItemDB context)
        {
            var auction = new Item[] {
                new Item {
                    Name = "Piano",
                    Description = "A Piece of Crap",
                    Condition = Condition.Used,
                    CurrentBid = 40.00m,
                    NewBid = new List<Bid>{
                        new Bid {BidderName = "Dan", BidAmount = 30m},
                        new Bid {BidderName = "JR", BidAmount = 40m}

                    }
                },
                new Item {
                    Name = "Camaro",
                    Description = "The Best Car EVER",
                    Condition = Condition.Antique
                },
                new Item {
                    Name = "Piano2",
                    Description = "A Piece of Crap",
                    Condition = Condition.Used
                },
                new Item {
                    Name = "BRZ",
                    Description = "Nice Car",
                    Condition = Condition.New
                },
                new Item {
                    Name = "Piano4",
                    Description = "A Piece of Crap",
                    Condition = Condition.Used
                },
                new Item {
                    Name = "Piano5",
                    Description = "A Piece of Crap",
                    Condition = Condition.Antique
                },
                new Item {
                    Name = "Stephen",
                    Description = "A Nice Guy",
                    Condition = Condition.Used

                }
            };
            context.Items.AddOrUpdate(c => c.Name, auction);
        }
    }
}
