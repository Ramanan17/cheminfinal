namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class missedMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CoordinatorforSites", "PlaceId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CoordinatorforSites", "PlaceId");
        }
    }
}
