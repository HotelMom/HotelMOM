namespace HotelDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IznajmljivanjeSeed : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT[dbo].[Iznajmljivanjes] ON " +
"INSERT INTO[dbo].[Iznajmljivanjes] ([Id], [GostId], [SobaId], [Gost_Gost_ID], [Soba_Sobe_ID]) VALUES(1, 1, 1, NULL, NULL) " +
"INSERT INTO[dbo].[Iznajmljivanjes] ([Id], [GostId], [SobaId], [Gost_Gost_ID], [Soba_Sobe_ID]) VALUES(2, 2, 2, NULL, NULL) " +
"INSERT INTO[dbo].[Iznajmljivanjes] ([Id], [GostId], [SobaId], [Gost_Gost_ID], [Soba_Sobe_ID]) VALUES(3, 3, 3, NULL, NULL) " +
"INSERT INTO[dbo].[Iznajmljivanjes] ([Id], [GostId], [SobaId], [Gost_Gost_ID], [Soba_Sobe_ID]) VALUES(4, 4, 4, NULL, NULL) " +
"SET IDENTITY_INSERT[dbo].[Iznajmljivanjes] OFF");

    }
        
        public override void Down()
        {
        }
    }
}
