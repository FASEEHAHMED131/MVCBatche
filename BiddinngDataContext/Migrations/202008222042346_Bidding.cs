namespace BiddinngDataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bidding : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auctions",
                c => new
                    {
                        AuctionID = c.Int(nullable: false, identity: true),
                        AuctionTitle = c.String(),
                        AuctionImageUrl = c.String(),
                        AuctionAmount = c.String(),
                        AuctionDescription = c.String(),
                        BiddingStartTime = c.DateTime(nullable: false),
                        BiddingEndTime = c.DateTime(nullable: false),
                        BiddingAmount = c.String(),
                    })
                .PrimaryKey(t => t.AuctionID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Auctions");
        }
    }
}
