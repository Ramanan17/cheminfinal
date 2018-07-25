namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mlbal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeDetails2", "MLBAL", c => c.Single(nullable: false));
            AddColumn("dbo.EmployeeDetails3", "MLBAL", c => c.Single(nullable: false));
            AddColumn("dbo.EmployeeDetails", "MLBAL", c => c.Single(nullable: false));
            DropColumn("dbo.EmployeeDetails2", "MLLBAL");
            DropColumn("dbo.EmployeeDetails3", "MLLBAL");
            DropColumn("dbo.EmployeeDetails", "MLLBAL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeeDetails", "MLLBAL", c => c.Single(nullable: false));
            AddColumn("dbo.EmployeeDetails3", "MLLBAL", c => c.Single(nullable: false));
            AddColumn("dbo.EmployeeDetails2", "MLLBAL", c => c.Single(nullable: false));
            DropColumn("dbo.EmployeeDetails", "MLBAL");
            DropColumn("dbo.EmployeeDetails3", "MLBAL");
            DropColumn("dbo.EmployeeDetails2", "MLBAL");
        }
    }
}
