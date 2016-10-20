namespace TurnipTheBeetMKE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedmanagermodel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Managers", "ManagerCode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Managers", "ManagerCode", c => c.String());
        }
    }
}
