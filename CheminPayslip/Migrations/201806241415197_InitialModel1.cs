namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeDetails", "Remarks", c => c.String());
            AddColumn("dbo.EmployeeDetails", "Place", c => c.String());
           
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeDetails", "Place");
            DropColumn("dbo.EmployeeDetails", "Remarks");
        }
    }
}
