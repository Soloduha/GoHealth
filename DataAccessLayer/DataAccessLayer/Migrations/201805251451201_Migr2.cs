namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migr2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkDays", "StartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.WorkDays", "EndDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WorkDays", "EndDate");
            DropColumn("dbo.WorkDays", "StartDate");
        }
    }
}
