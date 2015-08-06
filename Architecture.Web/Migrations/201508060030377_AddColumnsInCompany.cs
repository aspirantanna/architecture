namespace Architecture.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnsInCompany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "PFRegnNo", c => c.String());
            AddColumn("dbo.Companies", "PFPercentage", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Companies", "ESICRegnNo", c => c.String());
            AddColumn("dbo.Companies", "ESICPercentage", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Companies", "TAN", c => c.String());
            AddColumn("dbo.Companies", "PAN", c => c.String());
            AddColumn("dbo.Companies", "PTaxRegnNo", c => c.String());
            AlterColumn("dbo.Companies", "CompanyName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "CompanyName", c => c.String());
            DropColumn("dbo.Companies", "PTaxRegnNo");
            DropColumn("dbo.Companies", "PAN");
            DropColumn("dbo.Companies", "TAN");
            DropColumn("dbo.Companies", "ESICPercentage");
            DropColumn("dbo.Companies", "ESICRegnNo");
            DropColumn("dbo.Companies", "PFPercentage");
            DropColumn("dbo.Companies", "PFRegnNo");
        }
    }
}
