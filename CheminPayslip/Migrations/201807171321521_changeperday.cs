namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeperday : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MasterSites", "perdaysalary", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MasterSites", "perdaysalary", c => c.Int(nullable: false));
        }
    }
}
