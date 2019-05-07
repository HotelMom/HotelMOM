namespace HotelDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGosts : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Gosts ON " +
                "INSERT INTO Gosts ([Gost_ID], [Ime], [Prezime], [Broj_LK_Pasos], [PlacanjeId], [Placanje_Placanje_ID]) VALUES(1, 'Ivana', 'Ivkovic', '7123239555222', 1,null) " +
                "SET IDENTITY_INSERT Placanjes OFF");

            Sql("SET IDENTITY_INSERT Gosts ON " +
                  "INSERT INTO Gosts ([Gost_ID], [Ime], [Prezime], [Broj_LK_Pasos], [PlacanjeId], [Placanje_Placanje_ID]) VALUES(2, 'Dejan', 'Cvijeticanin', '7232238983487', 2 ,null) " +
                  "SET IDENTITY_INSERT Placanjes OFF");

            Sql("SET IDENTITY_INSERT Gosts ON " +
                  "INSERT INTO Gosts ([Gost_ID], [Ime], [Prezime], [Broj_LK_Pasos], [PlacanjeId], [Placanje_Placanje_ID]) VALUES(3, 'Jelena', 'Ilic', '7234218765672', 3 ,null) " +
                  "SET IDENTITY_INSERT Placanjes OFF");

            Sql("SET IDENTITY_INSERT Gosts ON " +
                  "INSERT INTO Gosts ([Gost_ID], [Ime], [Prezime], [Broj_LK_Pasos], [PlacanjeId], [Placanje_Placanje_ID]) VALUES(4, 'Aleksandar', 'Gak', '7771139986542', 1,null) " +
                  "SET IDENTITY_INSERT Placanjes OFF");

            Sql("SET IDENTITY_INSERT Gosts ON " +
                  "INSERT INTO Gosts ([Gost_ID], [Ime], [Prezime], [Broj_LK_Pasos], [PlacanjeId], [Placanje_Placanje_ID]) VALUES(5, 'Milutin', 'Beslic', '7122259891839', 3,null) " +
                  "SET IDENTITY_INSERT Placanjes OFF");

            Sql("SET IDENTITY_INSERT Gosts ON " +
                  "INSERT INTO Gosts ([Gost_ID], [Ime], [Prezime], [Broj_LK_Pasos], [PlacanjeId], [Placanje_Placanje_ID]) VALUES(6, 'Jelena', 'Lompar', '7122343891839', 2,null) " +
                  "SET IDENTITY_INSERT Placanjes OFF");

            Sql("SET IDENTITY_INSERT Gosts ON " +
                  "INSERT INTO Gosts ([Gost_ID], [Ime], [Prezime], [Broj_LK_Pasos], [PlacanjeId], [Placanje_Placanje_ID]) VALUES(7, 'Maja', 'Ognjanovic', '714353453459', 1,null) " +
                  "SET IDENTITY_INSERT Placanjes OFF");

            Sql("SET IDENTITY_INSERT Gosts ON " +
                  "INSERT INTO Gosts ([Gost_ID], [Ime], [Prezime], [Broj_LK_Pasos], [PlacanjeId], [Placanje_Placanje_ID]) VALUES(8, 'Djordje', 'Stari', '7123452352349', 3,null) " +
                  "SET IDENTITY_INSERT Placanjes OFF");

        }
        
        public override void Down()
        {
        }
    }
}
