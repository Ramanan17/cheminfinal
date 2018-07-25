namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allownulls2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MasterSites", "phoneno", c => c.Double());
            AlterColumn("dbo.MasterSites", "aadharno", c => c.Double());
            AlterColumn("dbo.MasterSites", "ptax", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MasterSites", "ptax", c => c.Double(nullable: false));
            AlterColumn("dbo.MasterSites", "aadharno", c => c.Double(nullable: false));
            AlterColumn("dbo.MasterSites", "phoneno", c => c.Double(nullable: false));
        }
    }
}
