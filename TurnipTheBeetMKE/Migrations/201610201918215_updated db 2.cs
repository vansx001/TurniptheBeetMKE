namespace TurnipTheBeetMKE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateddb2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Addresses", "BusinessName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "BusinessName", c => c.String());
        }
    }
}
