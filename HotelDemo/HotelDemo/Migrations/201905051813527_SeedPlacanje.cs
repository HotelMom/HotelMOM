namespace HotelDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedPlacanje : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Placanjes ON " +
                "INSERT INTO Placanjes (Placanje_ID, NacinPlacanja, Iznos, DatumPlacanja) Values (1, 'Cek', 3000, '2019.05.07' ) " +
                "SET IDENTITY_INSERT Placanjes OFF");
            Sql("SET IDENTITY_INSERT Placanjes ON " +
                "INSERT INTO Placanjes (Placanje_ID, NacinPlacanja, Iznos, DatumPlacanja) Values (2, 'Kartica', 3500, '2019.05.08') " +
                "SET IDENTITY_INSERT Placanjes OFF");
            Sql("SET IDENTITY_INSERT Placanjes ON " +
                "INSERT INTO Placanjes (Placanje_ID, NacinPlacanja, Iznos, DatumPlacanja) Values (3, 'Gotovina', 4000, '2019.05.09') " +
                "SET IDENTITY_INSERT Placanjes OFF");
                
        }
        
        public override void Down()
        {
        }
    }
}



  