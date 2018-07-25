namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finalModel3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeDetails", "INCOMETAX", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeDetails", "INCOMETAX", c => c.String());
        }
    }
}
