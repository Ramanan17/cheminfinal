namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commitments", "exptot", c => c.Double());
            AddColumn("dbo.Commitments", "BillTot", c => c.Double());
            AddColumn("dbo.Commitments", "BillOut", c => c.Double());
            AddColumn("dbo.Commitments", "Adhoc", c => c.Double());
            AddColumn("dbo.Commitments", "expout", c => c.Double());
            AddColumn("dbo.Commitments", "AdvTotal", c => c.Double());
            AddColumn("dbo.Commitments2", "exptot", c => c.Double());
            AddColumn("dbo.Commitments2", "BillTot", c => c.Double());
            AddColumn("dbo.Commitments2", "BillOut", c => c.Double());
            AddColumn("dbo.Commitments2", "Adhoc", c => c.Double());
            AddColumn("dbo.Commitments2", "expout", c => c.Double());
            AddColumn("dbo.Commitments2", "AdvTotal", c => c.Double());
            AddColumn("dbo.EmployeeDetails", "Active", c => c.Boolean());
            AddColumn("dbo.Sites", "opbal", c => c.Double());
            AddColumn("dbo.Sites", "clbal", c => c.Double());
            AddColumn("dbo.Sites", "Active", c => c.Boolean());
            AddColumn("dbo.Sites", "Adhoc", c => c.Double());
            AddColumn("dbo.Sites", "startDate", c => c.String());
            AddColumn("dbo.Sites", "EndDate", c => c.String());
            AddColumn("dbo.Sites", "billTotal", c => c.Double());
            AddColumn("dbo.Sites", "BudTotal", c => c.Double());
            AddColumn("dbo.Sites", "BudOutstanding", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sites", "BudOutstanding");
            DropColumn("dbo.Sites", "BudTotal");
            DropColumn("dbo.Sites", "billTotal");
            DropColumn("dbo.Sites", "EndDate");
            DropColumn("dbo.Sites", "startDate");
            DropColumn("dbo.Sites", "Adhoc");
            DropColumn("dbo.Sites", "Active");
            DropColumn("dbo.Sites", "clbal");
            DropColumn("dbo.Sites", "opbal");
            DropColumn("dbo.EmployeeDetails", "Active");
            DropColumn("dbo.Commitments2", "AdvTotal");
            DropColumn("dbo.Commitments2", "expout");
            DropColumn("dbo.Commitments2", "Adhoc");
            DropColumn("dbo.Commitments2", "BillOut");
            DropColumn("dbo.Commitments2", "BillTot");
            DropColumn("dbo.Commitments2", "exptot");
            DropColumn("dbo.Commitments", "AdvTotal");
            DropColumn("dbo.Commitments", "expout");
            DropColumn("dbo.Commitments", "Adhoc");
            DropColumn("dbo.Commitments", "BillOut");
            DropColumn("dbo.Commitments", "BillTot");
            DropColumn("dbo.Commitments", "exptot");
        }
    }
}
