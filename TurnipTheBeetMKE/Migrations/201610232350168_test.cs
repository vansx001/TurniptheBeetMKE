namespace TurnipTheBeetMKE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "State", c => c.String());
            AlterColumn("dbo.Addresses", "ZipCode", c => c.Int(nullable: false));
            DropColumn("dbo.Addresses", "Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "Number", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "ZipCode", c => c.String(maxLength: 5));
            AlterColumn("dbo.Addresses", "State", c => c.String(maxLength: 2));
        }
    }
}
