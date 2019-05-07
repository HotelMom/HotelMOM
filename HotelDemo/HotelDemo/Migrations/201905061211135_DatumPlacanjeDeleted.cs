namespace HotelDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatumPlacanjeDeleted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Placanjes", "DatumPlacanja");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Placanjes", "DatumPlacanja", c => c.DateTime(nullable: false));
        }
    }
}
