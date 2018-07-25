namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foradmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sites", "EmployeeEsi", c => c.Double());
            AddColumn("dbo.Sites", "EmployerEsi", c => c.Double());
            AddColumn("dbo.Sites", "Grosstot", c => c.Double());
            AddColumn("dbo.Sites", "Esitot", c => c.Double());
            AddColumn("dbo.Sites", "Eetot", c => c.Double());
            AddColumn("dbo.Sites", "Nettot", c => c.Double());
            AddColumn("dbo.SubContracts", "Grosstot", c => c.Double());
            AddColumn("dbo.SubContracts", "Esitot", c => c.Double());
            AddColumn("dbo.SubContracts", "Eetot", c => c.Double());
            AddColumn("dbo.SubContracts", "Nettot", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SubContracts", "Nettot");
            DropColumn("dbo.SubContracts", "Eetot");
            DropColumn("dbo.SubContracts", "Esitot");
            DropColumn("dbo.SubContracts", "Grosstot");
            DropColumn("dbo.Sites", "Nettot");
            DropColumn("dbo.Sites", "Eetot");
            DropColumn("dbo.Sites", "Esitot");
            DropColumn("dbo.Sites", "Grosstot");
            DropColumn("dbo.Sites", "EmployerEsi");
            DropColumn("dbo.Sites", "EmployeeEsi");
        }
    }
}
