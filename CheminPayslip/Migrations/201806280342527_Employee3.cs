namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Employee3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeDetails3",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Name = c.String(),
                        BASIC = c.Int(nullable: false),
                        DA = c.Int(nullable: false),
                        HRA = c.Int(nullable: false),
                        UMA = c.Int(nullable: false),
                        ARREAR = c.Int(nullable: false),
                        LAYOFF = c.Int(nullable: false),
                        STIPEND = c.Int(nullable: false),
                        SITE = c.Int(nullable: false),
                        LOCAL_CONVEY = c.Int(nullable: false),
                        DISTANCE = c.Int(nullable: false),
                        RESPONSIBILITY = c.Int(nullable: false),
                        PROJECT = c.Int(nullable: false),
                        FMA = c.Int(nullable: false),
                        ATTINC = c.Int(nullable: false),
                        COMPOFF = c.Int(nullable: false),
                        HARD = c.Int(nullable: false),
                        OT = c.Int(nullable: false),
                        VA = c.Int(nullable: false),
                        SITESTIPEND = c.Int(nullable: false),
                        FOODSITE = c.Int(nullable: false),
                        FOODHO = c.Int(nullable: false),
                        SPECIAL_RES_ALLOW = c.Int(nullable: false),
                        LEADERSHIP = c.Int(nullable: false),
                        HOUSE_RENT = c.Int(nullable: false),
                        TOTAL = c.Int(nullable: false),
                        PF = c.Int(nullable: false),
                        LIC = c.Int(nullable: false),
                        ESI = c.Int(nullable: false),
                        EXCESS_PAY = c.Int(nullable: false),
                        SALADV = c.Int(nullable: false),
                        EMERADV = c.Int(nullable: false),
                        MARRADV = c.Int(nullable: false),
                        MAXINS = c.Int(nullable: false),
                        INCOMETAX = c.Int(nullable: false),
                        DEDTOTAL = c.Int(nullable: false),
                        NETTOTAL = c.Int(nullable: false),
                        OT_HOURS = c.Int(nullable: false),
                        CLCR = c.Int(nullable: false),
                        CLT = c.Int(nullable: false),
                        CLBAL = c.Int(nullable: false),
                        MLCR = c.Int(nullable: false),
                        MLT = c.Int(nullable: false),
                        MLLBAL = c.Int(nullable: false),
                        ELCR = c.Int(nullable: false),
                        ELT = c.Int(nullable: false),
                        ELBAL = c.Int(nullable: false),
                        Date = c.String(),
                        CTC = c.Int(nullable: false),
                        Remarks = c.String(),
                        Place = c.String(),
                        OTHERDISBURSEMENT = c.String(),
                        ADVINSTNO = c.String(),
                        MADVINSTNO = c.String(),
                        BANKAC = c.String(),
                        BANKNAME = c.String(),
                        PFUAN = c.String(),
                        ESICODE = c.String(),
                        DESIGNATION = c.String(),
                        GRADE = c.String(),
                        SITE1DAYS = c.String(),
                        SITE2DAYS = c.String(),
                        SITE3DAYS = c.String(),
                        HODAYS = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmployeeDetails3");
        }
    }
}
