namespace AuctionWebsiteV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sunday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bids", "BidAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Bids", "Amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bids", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Bids", "BidAmount");
        }
    }
}
