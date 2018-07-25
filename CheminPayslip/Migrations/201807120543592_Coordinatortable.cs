namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Coordinatortable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoordinatorforSites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CoordinatorName = c.String(),
                        EmpId = c.Int(nullable: false),
                        PassWord = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.MasterSites", "pfMemberId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MasterSites", "pfMemberId");
            DropTable("dbo.CoordinatorforSites");
        }
    }
}
