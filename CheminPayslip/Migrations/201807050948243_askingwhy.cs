namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class askingwhy : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeDetails2", "BASIC", c => c.Single(nullable: false));
            AlterColumn("dbo.EmployeeDetails3", "BASIC", c => c.Single(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "BASIC", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeDetails", "BASIC", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails3", "BASIC", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails2", "BASIC", c => c.Int(nullable: false));
        }
    }
}
