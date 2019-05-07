namespace HotelDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class last : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Iznajmljivanjes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GostId = c.Int(nullable: false),
                        SobaId = c.Int(nullable: false),
                        Gost_Gost_ID = c.Int(),
                        Soba_Sobe_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Gosts", t => t.Gost_Gost_ID)
                .ForeignKey("dbo.Sobas", t => t.Soba_Sobe_ID)
                .Index(t => t.Gost_Gost_ID)
                .Index(t => t.Soba_Sobe_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Iznajmljivanjes", "Soba_Sobe_ID", "dbo.Sobas");
            DropForeignKey("dbo.Iznajmljivanjes", "Gost_Gost_ID", "dbo.Gosts");
            DropIndex("dbo.Iznajmljivanjes", new[] { "Soba_Sobe_ID" });
            DropIndex("dbo.Iznajmljivanjes", new[] { "Gost_Gost_ID" });
            DropTable("dbo.Iznajmljivanjes");
        }
    }
}
