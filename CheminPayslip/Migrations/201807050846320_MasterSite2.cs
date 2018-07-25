namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MasterSite2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MasterSites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        name = c.String(),
                        Design = c.String(),
                        perdaysalary = c.Int(nullable: false),
                        nod = c.Single(nullable: false),
                        total = c.Single(nullable: false),
                        nodcoff = c.Single(nullable: false),
                        coggamt = c.Single(nullable: false),
                        otpperhour = c.Single(nullable: false),
                        nohours = c.Single(nullable: false),
                        otamt = c.Single(nullable: false),
                        grosswages = c.Single(nullable: false),
                        otherallow = c.Single(nullable: false),
                        advance = c.Single(nullable: false),
                        revocery = c.Single(nullable: false),
                        pf = c.Single(nullable: false),
                        esi = c.Single(nullable: false),
                        dedtot = c.Single(nullable: false),
                        netwages = c.Single(nullable: false),
                        pfuan = c.Single(nullable: false),
                        dob = c.DateTime(nullable: false),
                        fname = c.String(),
                        BankName = c.String(),
                        bankacno = c.String(),
                        branch = c.String(),
                        ifsccode = c.String(),
                        esicode = c.String(),
                        placeid = c.String(),
                        date = c.DateTime(nullable: false),
                        address = c.String(),
                        state = c.String(),
                        pincode = c.String(),
                        phoneno = c.Double(nullable: false),
                        emailId = c.String(),
                        aadharno = c.Double(nullable: false),
                        panno = c.String(),
                        doj = c.DateTime(nullable: false),
                        photo = c.Binary(),
                        ptax = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MasterSites");
        }
    }
}
