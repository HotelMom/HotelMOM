namespace HotelDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SobaStanje_SobeIntoBool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sobas", "Stanje_Sobe", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sobas", "Stanje_Sobe", c => c.String());
        }
    }
}
