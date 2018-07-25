namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoordPassword2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MasterSites", "LIC", c => c.String());
            AlterColumn("dbo.Sites", "CoordPassword", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sites", "CoordPassword", c => c.Int(nullable: false));
            DropColumn("dbo.MasterSites", "LIC");
        }
    }
}
