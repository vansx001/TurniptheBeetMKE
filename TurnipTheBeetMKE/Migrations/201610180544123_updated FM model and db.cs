namespace TurnipTheBeetMKE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedFMmodelanddb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FarmersMarkets",
                c => new
                {
                    FarmersMarketId = c.Int(nullable: false, identity: true),
                    marketname = c.String(),
                    Schedule = c.String(),
                    Address = c.String(),
                    Products = c.String(),
                    ZipCode = c.String(),
                })
                .PrimaryKey(t => t.FarmersMarketId);

        }
        
        public override void Down()
        {
            DropTable("dbo.FarmersMarkets");
        }
    }
}
