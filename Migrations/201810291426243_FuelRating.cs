namespace CarLotDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FuelRating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "FuelTankCapacity", c => c.Int(nullable: false));
            AddColumn("dbo.Vehicles", "Rating", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "Rating");
            DropColumn("dbo.Vehicles", "FuelTankCapacity");
        }
    }
}
