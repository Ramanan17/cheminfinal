namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Commitments2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commitments", "PELIC", c => c.Double());
            AddColumn("dbo.Commitments", "PEGross", c => c.Double());
            AddColumn("dbo.Commitments", "PEPF", c => c.Double());
            AddColumn("dbo.Commitments", "PEESI", c => c.Double());
            AddColumn("dbo.Commitments", "PEEPF", c => c.Double());
            AddColumn("dbo.Commitments", "PEEESI", c => c.Double());
            AddColumn("dbo.Commitments", "PENet", c => c.Double());
            AddColumn("dbo.Commitments", "PLGross", c => c.Double());
            AddColumn("dbo.Commitments", "PLPF", c => c.Double());
            AddColumn("dbo.Commitments", "PLESI", c => c.Double());
            AddColumn("dbo.Commitments", "PLEPF", c => c.Double());
            AddColumn("dbo.Commitments", "PLEESI", c => c.Double());
            AddColumn("dbo.Commitments", "PLNET", c => c.Double());
            AddColumn("dbo.Commitments", "PLLIC", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Commitments", "PLLIC");
            DropColumn("dbo.Commitments", "PLNET");
            DropColumn("dbo.Commitments", "PLEESI");
            DropColumn("dbo.Commitments", "PLEPF");
            DropColumn("dbo.Commitments", "PLESI");
            DropColumn("dbo.Commitments", "PLPF");
            DropColumn("dbo.Commitments", "PLGross");
            DropColumn("dbo.Commitments", "PENet");
            DropColumn("dbo.Commitments", "PEEESI");
            DropColumn("dbo.Commitments", "PEEPF");
            DropColumn("dbo.Commitments", "PEESI");
            DropColumn("dbo.Commitments", "PEPF");
            DropColumn("dbo.Commitments", "PEGross");
            DropColumn("dbo.Commitments", "PELIC");
        }
    }
}
