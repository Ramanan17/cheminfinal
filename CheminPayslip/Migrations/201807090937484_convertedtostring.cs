
namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class convertedtostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MasterSites", "pfuan", c => c.String());
            AlterColumn("dbo.MasterSites", "aadharno", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MasterSites", "aadharno", c => c.Double());
            AlterColumn("dbo.MasterSites", "pfuan", c => c.Single());
        }
    }
}
