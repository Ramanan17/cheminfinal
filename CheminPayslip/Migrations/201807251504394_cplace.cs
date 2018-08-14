namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cplace : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeDetails", "cPlace", c => c.String());
            AddColumn("dbo.EmployeeDetails", "gradeid", c => c.Double());
            AddColumn("dbo.MasterSites", "misc", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MasterSites", "misc");
            DropColumn("dbo.EmployeeDetails", "gradeid");
            DropColumn("dbo.EmployeeDetails", "cPlace");
        }
    }
}
