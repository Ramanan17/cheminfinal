namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMaster : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeDetails", "issued", c => c.Boolean());
            AddColumn("dbo.EmployeeDetails", "issueDate", c => c.String());
            AddColumn("dbo.MasterSites", "issued", c => c.Boolean());
            AddColumn("dbo.MasterSites", "issueDate", c => c.String());
            AddColumn("dbo.MasterSites", "resigned", c => c.Boolean());
            AddColumn("dbo.MasterSites", "resignedDate", c => c.String());
            AlterColumn("dbo.MasterSites", "remarks", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MasterSites", "remarks", c => c.Single());
            DropColumn("dbo.MasterSites", "resignedDate");
            DropColumn("dbo.MasterSites", "resigned");
            DropColumn("dbo.MasterSites", "issueDate");
            DropColumn("dbo.MasterSites", "issued");
            DropColumn("dbo.EmployeeDetails", "issueDate");
            DropColumn("dbo.EmployeeDetails", "issued");
        }
    }
}
