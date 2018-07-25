namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCL : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.EmployeeDetails");
            DropTable("dbo.EmployeeDetails2");
            DropTable("dbo.EmployeeDetails3");
        }
        
        public override void Down()
        {
           
        }
    }
}
