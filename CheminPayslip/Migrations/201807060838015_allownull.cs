namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allownull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MasterSites", "nod", c => c.Single());
            AlterColumn("dbo.MasterSites", "total", c => c.Single());
            AlterColumn("dbo.MasterSites", "nodcoff", c => c.Single());
            AlterColumn("dbo.MasterSites", "coggamt", c => c.Single());
            AlterColumn("dbo.MasterSites", "otpperhour", c => c.Single());
            AlterColumn("dbo.MasterSites", "nohours", c => c.Single());
            AlterColumn("dbo.MasterSites", "otamt", c => c.Single());
            AlterColumn("dbo.MasterSites", "TEA", c => c.Single());
            AlterColumn("dbo.MasterSites", "grosswages", c => c.Single());
            AlterColumn("dbo.MasterSites", "otherallow", c => c.Single());
            AlterColumn("dbo.MasterSites", "advance", c => c.Single());
            AlterColumn("dbo.MasterSites", "revocery", c => c.Single());
            AlterColumn("dbo.MasterSites", "pf", c => c.Single());
            AlterColumn("dbo.MasterSites", "esi", c => c.Single());
            AlterColumn("dbo.MasterSites", "TDS", c => c.Single());
            AlterColumn("dbo.MasterSites", "dedtot", c => c.Single());
            AlterColumn("dbo.MasterSites", "netwages", c => c.Single());
            AlterColumn("dbo.MasterSites", "pfuan", c => c.Single());
            AlterColumn("dbo.MasterSites", "date", c => c.DateTime());
            AlterColumn("dbo.MasterSites", "doj", c => c.DateTime());
            AlterColumn("dbo.MasterSites", "SUBID", c => c.Int());
            AlterColumn("dbo.MasterSites", "HouseRent", c => c.Int());
            AlterColumn("dbo.MasterSites", "clcr", c => c.Single());
            AlterColumn("dbo.MasterSites", "cltax", c => c.Single());
            AlterColumn("dbo.MasterSites", "clbal", c => c.Single());
            AlterColumn("dbo.MasterSites", "remarks", c => c.Single());
            AlterColumn("dbo.MasterSites", "pfelig", c => c.Boolean());
            AlterColumn("dbo.MasterSites", "esielig", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MasterSites", "esielig", c => c.Boolean(nullable: false));
            AlterColumn("dbo.MasterSites", "pfelig", c => c.Boolean(nullable: false));
            AlterColumn("dbo.MasterSites", "remarks", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "clbal", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "cltax", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "clcr", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "HouseRent", c => c.Int(nullable: false));
            AlterColumn("dbo.MasterSites", "SUBID", c => c.Int(nullable: false));
            AlterColumn("dbo.MasterSites", "doj", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MasterSites", "date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MasterSites", "pfuan", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "netwages", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "dedtot", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "TDS", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "esi", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "pf", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "revocery", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "advance", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "otherallow", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "grosswages", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "TEA", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "otamt", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "nohours", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "otpperhour", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "coggamt", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "nodcoff", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "total", c => c.Single(nullable: false));
            AlterColumn("dbo.MasterSites", "nod", c => c.Single(nullable: false));
        }
    }
}
