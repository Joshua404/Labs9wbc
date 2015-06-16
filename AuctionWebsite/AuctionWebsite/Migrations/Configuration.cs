namespace AuctionWebsite.Migrations
{
    using AuctionWebsite.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AuctionWebsite.Models.AuctionDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AuctionWebsite.Models.AuctionDB context)
        {
            var auction = new AuctionItem[] {
                new AuctionItem {
                    Name = "Piano",
                    Description = "A Piece of Crap",
                    Condition = Condition.Used
                },
                new AuctionItem {
                    Name = "Piano1",
                    Description = "A Piece of Crap",
                    Condition = Condition.Used
                },
                new AuctionItem {
                    Name = "Piano2",
                    Description = "A Piece of Crap",
                    Condition = Condition.Used
                },
                new AuctionItem {
                    Name = "Piano3",
                    Description = "A Piece of Crap",
                    Condition = Condition.Used
                },
                new AuctionItem {
                    Name = "Piano4",
                    Description = "A Piece of Crap",
                    Condition = Condition.Used
                },
                new AuctionItem {
                    Name = "Piano5",
                    Description = "A Piece of Crap",
                    Condition = Condition.Used
                },
                new AuctionItem {
                    Name = "Piano6",
                    Description = "A Piece of Crap",
                    Condition = Condition.Used

                }
            };
            context.AuctionItems.AddOrUpdate(c => c.Name, auction);
        }
    }
}
