namespace TurnipTheBeetMKE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedmodels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FarmersMarkets", "GoogleMapId", c => c.Int());
            AddColumn("dbo.Managers", "VendorId", c => c.Int());
            CreateIndex("dbo.FarmersMarkets", "GoogleMapId");
            CreateIndex("dbo.Managers", "VendorId");
            AddForeignKey("dbo.FarmersMarkets", "GoogleMapId", "dbo.GoogleMaps", "Id");
            AddForeignKey("dbo.Managers", "VendorId", "dbo.Vendors", "VendorId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Managers", "VendorId", "dbo.Vendors");
            DropForeignKey("dbo.FarmersMarkets", "GoogleMapId", "dbo.GoogleMaps");
            DropIndex("dbo.Managers", new[] { "VendorId" });
            DropIndex("dbo.FarmersMarkets", new[] { "GoogleMapId" });
            DropColumn("dbo.Managers", "VendorId");
            DropColumn("dbo.FarmersMarkets", "GoogleMapId");
        }
    }
}
