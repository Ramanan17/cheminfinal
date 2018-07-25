namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finalmodelEmpDetails2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EmployeeDetails", "Designation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeeDetails", "Designation", c => c.String());
        }
    }
}
