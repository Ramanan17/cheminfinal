namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.EmployeeDetails");
            AlterColumn("dbo.EmployeeDetails", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.EmployeeDetails", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.EmployeeDetails");
            AlterColumn("dbo.EmployeeDetails", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.EmployeeDetails", "Id");
        }
    }
}
