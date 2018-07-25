namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MasterSites", "dob", c => c.String());
            AlterColumn("dbo.MasterSites", "date", c => c.String());
            AlterColumn("dbo.MasterSites", "doj", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MasterSites", "doj", c => c.DateTime());
            AlterColumn("dbo.MasterSites", "date", c => c.DateTime());
            AlterColumn("dbo.MasterSites", "dob", c => c.DateTime(nullable: false));
        }
    }
}
