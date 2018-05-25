namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migr4 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Receptions", name: "MyProperty_Id", newName: "Patient_Id");
            RenameIndex(table: "dbo.Receptions", name: "IX_MyProperty_Id", newName: "IX_Patient_Id");
            DropColumn("dbo.Notes", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Notes", "MyProperty", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.Receptions", name: "IX_Patient_Id", newName: "IX_MyProperty_Id");
            RenameColumn(table: "dbo.Receptions", name: "Patient_Id", newName: "MyProperty_Id");
        }
    }
}
