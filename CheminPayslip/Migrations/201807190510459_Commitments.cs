namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Commitments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Commitments",
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
                        ELIC = c.Double(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Commitments");
        }
    }
}
