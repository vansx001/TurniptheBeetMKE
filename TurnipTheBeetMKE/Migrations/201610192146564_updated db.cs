namespace TurnipTheBeetMKE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateddb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VendorCustomers",
                c => new
                    {
                        Vendor_VendorId = c.Int(nullable: false),
                        Customer_CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Vendor_VendorId, t.Customer_CustomerId })
                .ForeignKey("dbo.Vendors", t => t.Vendor_VendorId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId, cascadeDelete: true)
                .Index(t => t.Vendor_VendorId)
                .Index(t => t.Customer_CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VendorCustomers", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.VendorCustomers", "Vendor_VendorId", "dbo.Vendors");
            DropIndex("dbo.VendorCustomers", new[] { "Customer_CustomerId" });
            DropIndex("dbo.VendorCustomers", new[] { "Vendor_VendorId" });
            DropTable("dbo.VendorCustomers");
        }
    }
}
