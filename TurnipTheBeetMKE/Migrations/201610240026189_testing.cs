namespace TurnipTheBeetMKE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "Number", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "State", c => c.String(maxLength: 2));
            AlterColumn("dbo.Addresses", "ZipCode", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "ZipCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Addresses", "State", c => c.String());
            DropColumn("dbo.Addresses", "Number");
        }
    }
}
