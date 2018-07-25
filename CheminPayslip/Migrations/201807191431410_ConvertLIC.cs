namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConvertLIC : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MasterSites", "LIC", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MasterSites", "LIC", c => c.String());
        }
    }
}
