namespace AuctionWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cool : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bids",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AuctionItem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AuctionItems", t => t.AuctionItem_Id)
                .Index(t => t.AuctionItem_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bids", "AuctionItem_Id", "dbo.AuctionItems");
            DropIndex("dbo.Bids", new[] { "AuctionItem_Id" });
            DropTable("dbo.Bids");
        }
    }
}
