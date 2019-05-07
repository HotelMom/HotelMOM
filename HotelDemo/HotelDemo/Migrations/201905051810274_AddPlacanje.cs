namespace HotelDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlacanje : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Placanjes",
                c => new
                    {
                        Placanje_ID = c.Int(nullable: false, identity: true),
                        NacinPlacanja = c.String(),
                        Iznos = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DatumPlacanja = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Placanje_ID);
            
            AddColumn("dbo.Gosts", "PlacanjeId", c => c.Int(nullable: false));
            AddColumn("dbo.Gosts", "Placanje_Placanje_ID", c => c.Int());
            CreateIndex("dbo.Gosts", "Placanje_Placanje_ID");
            AddForeignKey("dbo.Gosts", "Placanje_Placanje_ID", "dbo.Placanjes", "Placanje_ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gosts", "Placanje_Placanje_ID", "dbo.Placanjes");
            DropIndex("dbo.Gosts", new[] { "Placanje_Placanje_ID" });
            DropColumn("dbo.Gosts", "Placanje_Placanje_ID");
            DropColumn("dbo.Gosts", "PlacanjeId");
            DropTable("dbo.Placanjes");
        }
    }
}
