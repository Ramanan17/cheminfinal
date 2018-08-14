namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MasterDetails3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MasterDetails2", newName: "MasterDetailsBackUps");
            CreateTable(
                "dbo.MasterDetails3",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        name = c.String(),
                        Design = c.String(),
                        perdaysalary = c.Single(),
                        nod = c.Single(),
                        total = c.Single(),
                        nodcoff = c.Single(),
                        coggamt = c.Single(),
                        otpperhour = c.Single(),
                        nohours = c.Single(),
                        otamt = c.Single(),
                        TEA = c.Single(),
                        grosswages = c.Single(),
                        otherallow = c.Single(),
                        advance = c.Single(),
                        revocery = c.Single(),
                        pf = c.Single(),
                        esi = c.Single(),
                        TDS = c.Single(),
                        dedtot = c.Single(),
                        netwages = c.Single(),
                        pfuan = c.String(),
                        dob = c.String(),
                        fname = c.String(),
                        BankName = c.String(),
                        bankacno = c.String(),
                        branch = c.String(),
                        ifsccode = c.String(),
                        esicode = c.String(),
                        placeid = c.String(),
                        date = c.String(),
                        address = c.String(),
                        state = c.String(),
                        pincode = c.String(),
                        phoneno = c.Double(),
                        emailId = c.String(),
                        aadharno = c.String(),
                        panno = c.String(),
                        doj = c.String(),
                        photo = c.Binary(),
                        ptax = c.Double(),
                        SUBID = c.Int(),
                        HouseRent = c.Int(),
                        clcr = c.Single(),
                        cltax = c.Single(),
                        clbal = c.Single(),
                        remarks = c.String(),
                        pfelig = c.Boolean(),
                        esielig = c.Boolean(),
                        pfMemberId = c.String(),
                        LIC = c.Double(),
                        issued = c.Boolean(),
                        issueDate = c.String(),
                        resigned = c.Boolean(),
                        resignedDate = c.String(),
                        Misc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.MasterDetailsBackUps", "Misc2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MasterDetailsBackUps", "Misc2");
            DropTable("dbo.MasterDetails3");
            RenameTable(name: "dbo.MasterDetailsBackUps", newName: "MasterDetails2");
        }
    }
}
