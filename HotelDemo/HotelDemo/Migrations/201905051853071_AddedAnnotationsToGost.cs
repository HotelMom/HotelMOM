namespace HotelDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAnnotationsToGost : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Gosts", "Ime", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Gosts", "Broj_LK_Pasos", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Gosts", "Broj_LK_Pasos", c => c.String());
            AlterColumn("dbo.Gosts", "Ime", c => c.String());
        }
    }
}
