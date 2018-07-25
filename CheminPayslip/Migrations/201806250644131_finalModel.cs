namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finalModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeDetails", "OTHERDISBURSEMENT", c => c.String());
            AddColumn("dbo.EmployeeDetails", "ADVINSTNO", c => c.String());
            AddColumn("dbo.EmployeeDetails", "MADVINSTNO", c => c.String());
            AddColumn("dbo.EmployeeDetails", "BANKAC", c => c.String());
            AddColumn("dbo.EmployeeDetails", "BANKNAME", c => c.String());
            AddColumn("dbo.EmployeeDetails", "PFUAN", c => c.String());
            AddColumn("dbo.EmployeeDetails", "ESICODE", c => c.String());
            AddColumn("dbo.EmployeeDetails", "DESIGNATION", c => c.String());
            AddColumn("dbo.EmployeeDetails", "GRADE", c => c.String());
            AddColumn("dbo.EmployeeDetails", "SITE1DAYS", c => c.String());
            AddColumn("dbo.EmployeeDetails", "SITE2DAYS", c => c.String());
            AddColumn("dbo.EmployeeDetails", "SITE3DAYS", c => c.String());
            AddColumn("dbo.EmployeeDetails", "HODAYS", c => c.String());
            
        }
        
        public override void Down()
        {
           
            DropColumn("dbo.EmployeeDetails", "HODAYS");
            DropColumn("dbo.EmployeeDetails", "SITE3DAYS");
            DropColumn("dbo.EmployeeDetails", "SITE2DAYS");
            DropColumn("dbo.EmployeeDetails", "SITE1DAYS");
            DropColumn("dbo.EmployeeDetails", "GRADE");
            DropColumn("dbo.EmployeeDetails", "DESIGNATION");
            DropColumn("dbo.EmployeeDetails", "ESICODE");
            DropColumn("dbo.EmployeeDetails", "PFUAN");
            DropColumn("dbo.EmployeeDetails", "BANKNAME");
            DropColumn("dbo.EmployeeDetails", "BANKAC");
            DropColumn("dbo.EmployeeDetails", "MADVINSTNO");
            DropColumn("dbo.EmployeeDetails", "ADVINSTNO");
            DropColumn("dbo.EmployeeDetails", "OTHERDISBURSEMENT");
        }
    }
}
