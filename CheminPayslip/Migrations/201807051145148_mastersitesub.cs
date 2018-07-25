namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mastersitesub : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MasterSites", "SubContractId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MasterSites", "SubContractId");
        }
    }
}
