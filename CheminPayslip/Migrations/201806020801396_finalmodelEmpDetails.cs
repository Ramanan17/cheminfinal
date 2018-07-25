namespace CheminPayslip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finalmodelEmpDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeDetails", "BASIC", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "DA", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "HRA", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "UMA", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "ARREAR", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "LAYOFF", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "STIPEND", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "SITE", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "LOCAL_CONVEY", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "DISTANCE", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "RESPONSIBILITY", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "PROJECT", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "FMA", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "ATTINC", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "COMPOFF", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "HARD", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "OT", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "VA", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "SITESTIPEND", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "FODDSITE", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "SPECIAL_RES_ALLOW", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "LEADERSHIP", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "HOUSE_RENT", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "TOTAL", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "PF", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "LIC", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "ESI", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "EXCESS_PAY", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "SALADV", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "EMERADV", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "MARRADV", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "MAXINS", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "INCOMETAX", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "OT_HOURS", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "CLCR", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "CLT", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "CLBAL", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "MLCR", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "MLT", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "MLLBAL", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "ELCR", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "ELT", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "ELBAL", c => c.Int(nullable: false));
            AddColumn("dbo.EmployeeDetails", "Date", c => c.String());
            AddColumn("dbo.EmployeeDetails", "CTC", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeDetails", "CTC");
            DropColumn("dbo.EmployeeDetails", "Date");
            DropColumn("dbo.EmployeeDetails", "ELBAL");
            DropColumn("dbo.EmployeeDetails", "ELT");
            DropColumn("dbo.EmployeeDetails", "ELCR");
            DropColumn("dbo.EmployeeDetails", "MLLBAL");
            DropColumn("dbo.EmployeeDetails", "MLT");
            DropColumn("dbo.EmployeeDetails", "MLCR");
            DropColumn("dbo.EmployeeDetails", "CLBAL");
            DropColumn("dbo.EmployeeDetails", "CLT");
            DropColumn("dbo.EmployeeDetails", "CLCR");
            DropColumn("dbo.EmployeeDetails", "OT_HOURS");
            DropColumn("dbo.EmployeeDetails", "INCOMETAX");
            DropColumn("dbo.EmployeeDetails", "MAXINS");
            DropColumn("dbo.EmployeeDetails", "MARRADV");
            DropColumn("dbo.EmployeeDetails", "EMERADV");
            DropColumn("dbo.EmployeeDetails", "SALADV");
            DropColumn("dbo.EmployeeDetails", "EXCESS_PAY");
            DropColumn("dbo.EmployeeDetails", "ESI");
            DropColumn("dbo.EmployeeDetails", "LIC");
            DropColumn("dbo.EmployeeDetails", "PF");
            DropColumn("dbo.EmployeeDetails", "TOTAL");
            DropColumn("dbo.EmployeeDetails", "HOUSE_RENT");
            DropColumn("dbo.EmployeeDetails", "LEADERSHIP");
            DropColumn("dbo.EmployeeDetails", "SPECIAL_RES_ALLOW");
            DropColumn("dbo.EmployeeDetails", "FODDSITE");
            DropColumn("dbo.EmployeeDetails", "SITESTIPEND");
            DropColumn("dbo.EmployeeDetails", "VA");
            DropColumn("dbo.EmployeeDetails", "OT");
            DropColumn("dbo.EmployeeDetails", "HARD");
            DropColumn("dbo.EmployeeDetails", "COMPOFF");
            DropColumn("dbo.EmployeeDetails", "ATTINC");
            DropColumn("dbo.EmployeeDetails", "FMA");
            DropColumn("dbo.EmployeeDetails", "PROJECT");
            DropColumn("dbo.EmployeeDetails", "RESPONSIBILITY");
            DropColumn("dbo.EmployeeDetails", "DISTANCE");
            DropColumn("dbo.EmployeeDetails", "LOCAL_CONVEY");
            DropColumn("dbo.EmployeeDetails", "SITE");
            DropColumn("dbo.EmployeeDetails", "STIPEND");
            DropColumn("dbo.EmployeeDetails", "LAYOFF");
            DropColumn("dbo.EmployeeDetails", "ARREAR");
            DropColumn("dbo.EmployeeDetails", "UMA");
            DropColumn("dbo.EmployeeDetails", "HRA");
            DropColumn("dbo.EmployeeDetails", "DA");
            DropColumn("dbo.EmployeeDetails", "BASIC");
        }
    }
}
