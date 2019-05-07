namespace HotelDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bla : DbMigration
    {
        public override void Up()
        {
            Sql(
            "UPDATE sobas SET stanje_sobe = 'true' WHERE broj_sobe=1 " +
            "UPDATE sobas SET stanje_sobe = 'true' WHERE broj_sobe=2 " +
            "UPDATE sobas SET stanje_sobe = 'true' WHERE broj_sobe=3 " +
            "UPDATE sobas SET stanje_sobe = 'true' WHERE broj_sobe=4 "
            );

        }
        
        public override void Down()
        {
        }
    }
}
