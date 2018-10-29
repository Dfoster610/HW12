namespace CarLotDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedfields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "Make", c => c.String());
            AlterColumn("dbo.Vehicles", "Model", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Model", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehicles", "Make", c => c.Int(nullable: false));
        }
    }
}
