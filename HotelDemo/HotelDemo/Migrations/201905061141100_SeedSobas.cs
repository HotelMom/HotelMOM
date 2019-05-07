namespace HotelDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedSobas : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT[dbo].[Sobas] ON " +
                "INSERT INTO[dbo].[Sobas]([Sobe_ID], [Sprat], [Pogled], [Broj_Sobe], [Tip_Sobe], [Stanje_Sobe]) VALUES(1, N'1', N'Ulica', 1, N'Jednokrevetna', 0) " +
                "INSERT INTO[dbo].[Sobas] ([Sobe_ID], [Sprat], [Pogled], [Broj_Sobe], [Tip_Sobe], [Stanje_Sobe]) VALUES(2, N'1', N'Dvoriste', 2, N'Dvokrevetna', 0) " +
                "INSERT INTO[dbo].[Sobas] ([Sobe_ID], [Sprat], [Pogled], [Broj_Sobe], [Tip_Sobe], [Stanje_Sobe]) VALUES(3, N'1', N'Park', 3, N'Trokrevetna', 0) " +
                "INSERT INTO[dbo].[Sobas] ([Sobe_ID], [Sprat], [Pogled], [Broj_Sobe], [Tip_Sobe], [Stanje_Sobe]) VALUES(4, N'1', N'Ulica', 4, N'Cetvorokrevetna', 0) " +
                "INSERT INTO[dbo].[Sobas] ([Sobe_ID], [Sprat], [Pogled], [Broj_Sobe], [Tip_Sobe], [Stanje_Sobe]) VALUES(5, N'2', N'Ulica', 5, N'Jednokrevetna', 0) " +
                "INSERT INTO[dbo].[Sobas] ([Sobe_ID], [Sprat], [Pogled], [Broj_Sobe], [Tip_Sobe], [Stanje_Sobe]) VALUES(6, N'2', N'Dvoriste', 6, N'Dvokrevetna', 0) " +
                "INSERT INTO[dbo].[Sobas] ([Sobe_ID], [Sprat], [Pogled], [Broj_Sobe], [Tip_Sobe], [Stanje_Sobe]) VALUES(7, N'2', N'Park', 7, N'Trokrevetna', 0) " +
                "INSERT INTO[dbo].[Sobas] ([Sobe_ID], [Sprat], [Pogled], [Broj_Sobe], [Tip_Sobe], [Stanje_Sobe]) VALUES(8, N'2', N'Ulica', 8, N'Cetvorokrevetna', 0) " +
                "INSERT INTO[dbo].[Sobas] ([Sobe_ID], [Sprat], [Pogled], [Broj_Sobe], [Tip_Sobe], [Stanje_Sobe]) VALUES(9, N'3', N'Ulica', 9, N'Jednokrevetna', 0) " +
                "INSERT INTO[dbo].[Sobas] ([Sobe_ID], [Sprat], [Pogled], [Broj_Sobe], [Tip_Sobe], [Stanje_Sobe]) VALUES(11, N'3', N'Dvoriste', 10, N'Dvokrevetna', 0) " +
                "INSERT INTO[dbo].[Sobas] ([Sobe_ID], [Sprat], [Pogled], [Broj_Sobe], [Tip_Sobe], [Stanje_Sobe]) VALUES(12, N'3', N'Park', 11, N'Trokrevetna', 0) " +
                "INSERT INTO[dbo].[Sobas] ([Sobe_ID], [Sprat], [Pogled], [Broj_Sobe], [Tip_Sobe], [Stanje_Sobe]) VALUES(13, N'3', N'Ulica', 12, N'Cetvorokrevetna', 0) " +
                "SET IDENTITY_INSERT[dbo].[Sobas] OFF");

        }
        
        public override void Down()
        {
        }
    }
}
