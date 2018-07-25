namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forprevious : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Commitments2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        placeid = c.Int(nullable: false),
                        PlaceName = c.String(),
                        SUBID = c.Int(nullable: false),
                        SubName = c.String(),
                        EGross = c.Double(),
                        EPF = c.Double(),
                        EESI = c.Double(),
                        EEPF = c.Double(),
                        EEESI = c.Double(),
                        ENet = c.Double(),
                        LGross = c.Double(),
                        LPF = c.Double(),
                        LESI = c.Double(),
                        LEPF = c.Double(),
                        LEESI = c.Double(),
                        LNET = c.Double(),
                        LLIC = c.Double(),
                        PELIC = c.Double(),
                        PEGross = c.Double(),
                        PEPF = c.Double(),
                        PEESI = c.Double(),
                        PEEPF = c.Double(),
                        PEEESI = c.Double(),
                        PENet = c.Double(),
                        PLGross = c.Double(),
                        PLPF = c.Double(),
                        PLESI = c.Double(),
                        PLEPF = c.Double(),
                        PLEESI = c.Double(),
                        PLNET = c.Double(),
                        PLLIC = c.Double(),
                        ELIC = c.Double(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MasterDetails2",
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
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MasterDetails2");
            DropTable("dbo.Commitments2");
        }
    }
}
