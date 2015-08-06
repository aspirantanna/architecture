namespace Architecture.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailWebsite : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Email", c => c.String());
            AddColumn("dbo.Companies", "Website", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "Website");
            DropColumn("dbo.Companies", "Email");
        }
    }
}
