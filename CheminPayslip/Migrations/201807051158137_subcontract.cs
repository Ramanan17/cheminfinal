namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class subcontract : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubContracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubContractId = c.Int(nullable: false),
                        PlaceId = c.Int(nullable: false),
                        SubContractorName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SubContracts");
        }
    }
}
