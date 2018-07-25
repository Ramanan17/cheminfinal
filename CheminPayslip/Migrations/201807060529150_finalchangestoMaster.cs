namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finalchangestoMaster : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MasterSites", "TEA", c => c.Single(nullable: false));
            AddColumn("dbo.MasterSites", "TDS", c => c.Single(nullable: false));
            AddColumn("dbo.MasterSites", "SUBID", c => c.Int(nullable: false));
            AddColumn("dbo.MasterSites", "HouseRent", c => c.Int(nullable: false));
            AddColumn("dbo.MasterSites", "clcr", c => c.Single(nullable: false));
            AddColumn("dbo.MasterSites", "cltax", c => c.Single(nullable: false));
            AddColumn("dbo.MasterSites", "clbal", c => c.Single(nullable: false));
            AddColumn("dbo.MasterSites", "remarks", c => c.Single(nullable: false));
            AddColumn("dbo.MasterSites", "pfelig", c => c.Boolean(nullable: false));
            AddColumn("dbo.MasterSites", "esielig", c => c.Boolean(nullable: false));
            DropColumn("dbo.MasterSites", "SubContractId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MasterSites", "SubContractId", c => c.Int(nullable: false));
            DropColumn("dbo.MasterSites", "esielig");
            DropColumn("dbo.MasterSites", "pfelig");
            DropColumn("dbo.MasterSites", "remarks");
            DropColumn("dbo.MasterSites", "clbal");
            DropColumn("dbo.MasterSites", "cltax");
            DropColumn("dbo.MasterSites", "clcr");
            DropColumn("dbo.MasterSites", "HouseRent");
            DropColumn("dbo.MasterSites", "SUBID");
            DropColumn("dbo.MasterSites", "TDS");
            DropColumn("dbo.MasterSites", "TEA");
        }
    }
}
