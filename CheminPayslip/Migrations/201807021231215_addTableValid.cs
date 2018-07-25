namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableValid : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TableValids",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TableName = c.String(),
                        IsValid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TableValids");
        }
    }
}
