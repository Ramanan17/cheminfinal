namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoordPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sites", "CoordPassword", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sites", "CoordPassword");
        }
    }
}
