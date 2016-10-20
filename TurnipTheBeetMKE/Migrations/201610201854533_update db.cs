namespace TurnipTheBeetMKE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ManagerVendors",
                c => new
                    {
                        Manager_ManagerId = c.Int(nullable: false),
                        Vendor_VendorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Manager_ManagerId, t.Vendor_VendorId })
                .ForeignKey("dbo.Managers", t => t.Manager_ManagerId, cascadeDelete: true)
                .ForeignKey("dbo.Vendors", t => t.Vendor_VendorId, cascadeDelete: true)
                .Index(t => t.Manager_ManagerId)
                .Index(t => t.Vendor_VendorId);
            
            AddColumn("dbo.Customers", "Manager_ManagerId", c => c.Int());
            AddColumn("dbo.Customers", "Vendor_VendorId", c => c.Int());
            AddColumn("dbo.FarmersMarkets", "GoogleMapId", c => c.Int());
            AddColumn("dbo.Managers", "VendorId", c => c.Int());
            AddColumn("dbo.Vendors", "ManagerId", c => c.Int());
            AlterColumn("dbo.Managers", "ManagerCode", c => c.String(nullable: false));
            AlterColumn("dbo.Vendors", "VendorCode", c => c.String(nullable: false));
            CreateIndex("dbo.Customers", "Manager_ManagerId");
            CreateIndex("dbo.Customers", "Vendor_VendorId");
            CreateIndex("dbo.FarmersMarkets", "GoogleMapId");
            AddForeignKey("dbo.FarmersMarkets", "GoogleMapId", "dbo.GoogleMaps", "Id");
            AddForeignKey("dbo.Customers", "Manager_ManagerId", "dbo.Managers", "ManagerId");
            AddForeignKey("dbo.Customers", "Vendor_VendorId", "dbo.Vendors", "VendorId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ManagerVendors", "Vendor_VendorId", "dbo.Vendors");
            DropForeignKey("dbo.ManagerVendors", "Manager_ManagerId", "dbo.Managers");
            DropForeignKey("dbo.Customers", "Vendor_VendorId", "dbo.Vendors");
            DropForeignKey("dbo.Customers", "Manager_ManagerId", "dbo.Managers");
            DropForeignKey("dbo.FarmersMarkets", "GoogleMapId", "dbo.GoogleMaps");
            DropIndex("dbo.ManagerVendors", new[] { "Vendor_VendorId" });
            DropIndex("dbo.ManagerVendors", new[] { "Manager_ManagerId" });
            DropIndex("dbo.FarmersMarkets", new[] { "GoogleMapId" });
            DropIndex("dbo.Customers", new[] { "Vendor_VendorId" });
            DropIndex("dbo.Customers", new[] { "Manager_ManagerId" });
            AlterColumn("dbo.Vendors", "VendorCode", c => c.String());
            AlterColumn("dbo.Managers", "ManagerCode", c => c.String());
            DropColumn("dbo.Vendors", "ManagerId");
            DropColumn("dbo.Managers", "VendorId");
            DropColumn("dbo.FarmersMarkets", "GoogleMapId");
            DropColumn("dbo.Customers", "Vendor_VendorId");
            DropColumn("dbo.Customers", "Manager_ManagerId");
            DropTable("dbo.ManagerVendors");
        }
    }
}
