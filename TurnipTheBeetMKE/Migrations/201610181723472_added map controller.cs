namespace TurnipTheBeetMKE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmapcontroller : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GoogleMaps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrentLocation = c.String(),
                        Destination = c.String(),
                        Name = c.String(),
                        Address = c.String(),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GoogleMaps");
        }
    }
}
