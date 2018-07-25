namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finalmodelEmpDetails3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeDetails", "FOODSITE", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "FOODHO", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "DEDTOTAL", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "NETTOTAL", c => c.Int(nullable: false));
            DropColumn("dbo.EmployeeDetails", "FODDSITE");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeeDetails", "FODDSITE", c => c.Int(nullable: false));
            DropColumn("dbo.EmployeeDetails", "NETTOTAL");
            DropColumn("dbo.EmployeeDetails", "DEDTOTAL");
            DropColumn("dbo.EmployeeDetails", "FOODHO");
            DropColumn("dbo.EmployeeDetails", "FOODSITE");
        }
    }
}
