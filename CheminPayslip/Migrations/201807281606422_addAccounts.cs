namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAccounts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccTrans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        placeid = c.Int(nullable: false),
                        subid = c.Int(nullable: false),
                        booktypeid = c.Int(),
                        exoensetypeid = c.Int(),
                        voucherid = c.Int(),
                        date = c.String(),
                        budgetamt = c.Double(),
                        amtpaid = c.Double(),
                        adhocrecd = c.Double(),
                        amtcred = c.Double(),
                        billno = c.String(),
                        billamt = c.Double(),
                        retamt = c.Double(),
                        balance = c.Double(),
                        modelid = c.Int(nullable: false),
                        neftid = c.Int(nullable: false),
                        varchar = c.String(),
                        misc = c.Double(nullable: false),
                        approved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.booktypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        bookType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.expensetypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        expenseType = c.String(),
                        groupid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.groupMasters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        groupname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ModelTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModelName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.nefttables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Placeid = c.Int(nullable: false),
                        Accname = c.String(),
                        Bank = c.String(),
                        Branch = c.String(),
                        IFSCCODE = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.voucherTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        vouchername = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.MasterDetails2", "Misc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MasterDetails2", "Misc");
            DropTable("dbo.voucherTables");
            DropTable("dbo.nefttables");
            DropTable("dbo.ModelTables");
            DropTable("dbo.groupMasters");
            DropTable("dbo.expensetypes");
            DropTable("dbo.booktypes");
            DropTable("dbo.AccTrans");
        }
    }
}
