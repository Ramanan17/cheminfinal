namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeDetails", "EmployeeId", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "BASIC", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "DA", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "HRA", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "UMA", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "ARREAR", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "LAYOFF", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "STIPEND", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "SITE", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "LOCAL_CONVEY", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "DISTANCE", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "RESPONSIBILITY", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "PROJECT", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "FMA", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "ATTINC", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "COMPOFF", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "HARD", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "OT", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "VA", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "SITESTIPEND", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "FOODSITE", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "FOODHO", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "SPECIAL_RES_ALLOW", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "LEADERSHIP", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "HOUSE_RENT", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "TOTAL", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "PF", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "LIC", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "ESI", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "EXCESS_PAY", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "SALADV", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "EMERADV", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "MARRADV", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "MAXINS", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "INCOMETAX", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "DEDTOTAL", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "NETTOTAL", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "OT_HOURS", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "CLCR", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "CLT", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "CLBAL", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "MLCR", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "MLT", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "MLLBAL", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "ELCR", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "ELT", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "ELBAL", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeDetails", "CTC", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeDetails", "CTC", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "ELBAL", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "ELT", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "ELCR", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "MLLBAL", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "MLT", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "MLCR", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "CLBAL", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "CLT", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "CLCR", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "OT_HOURS", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "NETTOTAL", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "DEDTOTAL", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "INCOMETAX", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "MAXINS", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "MARRADV", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "EMERADV", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "SALADV", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "EXCESS_PAY", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "ESI", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "LIC", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "PF", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "TOTAL", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "HOUSE_RENT", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "LEADERSHIP", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "SPECIAL_RES_ALLOW", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "FOODHO", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "FOODSITE", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "SITESTIPEND", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "VA", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "OT", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "HARD", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "COMPOFF", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "ATTINC", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "FMA", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "PROJECT", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "RESPONSIBILITY", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "DISTANCE", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "LOCAL_CONVEY", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "SITE", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "STIPEND", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "LAYOFF", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "ARREAR", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "UMA", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "HRA", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "DA", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "BASIC", c => c.String());
            AlterColumn("dbo.EmployeeDetails", "EmployeeId", c => c.String());
        }
    }
}
