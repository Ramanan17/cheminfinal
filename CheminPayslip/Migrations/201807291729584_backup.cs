namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class backup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeDetails2", "issued", c => c.Boolean());
            AddColumn("dbo.EmployeeDetails2", "issueDate", c => c.String());
            AddColumn("dbo.EmployeeDetails2", "cPlace", c => c.String());
            AddColumn("dbo.EmployeeDetails2", "gradeid", c => c.Double());
            AddColumn("dbo.EmployeeDetails3", "issued", c => c.Boolean());
            AddColumn("dbo.EmployeeDetails3", "issueDate", c => c.String());
            AddColumn("dbo.EmployeeDetails3", "cPlace", c => c.String());
            AddColumn("dbo.EmployeeDetails3", "gradeid", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeDetails3", "gradeid");
            DropColumn("dbo.EmployeeDetails3", "cPlace");
            DropColumn("dbo.EmployeeDetails3", "issueDate");
            DropColumn("dbo.EmployeeDetails3", "issued");
            DropColumn("dbo.EmployeeDetails2", "gradeid");
            DropColumn("dbo.EmployeeDetails2", "cPlace");
            DropColumn("dbo.EmployeeDetails2", "issueDate");
            DropColumn("dbo.EmployeeDetails2", "issued");
        }
    }
}
