namespace TurnipTheBeetMKE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedvendormodel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vendors", "VendorCode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendors", "VendorCode", c => c.String());
        }
    }
}
