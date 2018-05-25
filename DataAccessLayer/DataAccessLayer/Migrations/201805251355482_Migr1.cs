namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migr1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiseaseHistories",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Medicine = c.String(),
                        MyProperty = c.Int(nullable: false),
                        Disease_Id = c.Int(),
                        DiseaseHistory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Diseases", t => t.Disease_Id)
                .ForeignKey("dbo.DiseaseHistories", t => t.DiseaseHistory_Id)
                .Index(t => t.Disease_Id)
                .Index(t => t.DiseaseHistory_Id);
            
            CreateTable(
                "dbo.Diseases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DiseaseStatus_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DiseaseStatus", t => t.DiseaseStatus_Id)
                .Index(t => t.DiseaseStatus_Id);
            
            CreateTable(
                "dbo.DiseaseStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Receptions",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DateOfRegistration = c.DateTime(nullable: false),
                        Doctor_Id = c.Int(nullable: false),
                        MyProperty_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.MyProperty_Id, cascadeDelete: true)
                .ForeignKey("dbo.Notes", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.Doctor_Id)
                .Index(t => t.MyProperty_Id);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SecondName = c.String(nullable: false),
                        ThirdName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkDayDoctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Doctor_Id = c.Int(nullable: false),
                        WorkDay_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Id, cascadeDelete: true)
                .ForeignKey("dbo.WorkDays", t => t.WorkDay_Id, cascadeDelete: true)
                .Index(t => t.Doctor_Id)
                .Index(t => t.WorkDay_Id);
            
            CreateTable(
                "dbo.WorkDays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        ThirdName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Receptions", "Id", "dbo.Notes");
            DropForeignKey("dbo.Receptions", "MyProperty_Id", "dbo.Patients");
            DropForeignKey("dbo.DiseaseHistories", "Id", "dbo.Patients");
            DropForeignKey("dbo.Receptions", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.WorkDayDoctors", "WorkDay_Id", "dbo.WorkDays");
            DropForeignKey("dbo.WorkDayDoctors", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.Notes", "DiseaseHistory_Id", "dbo.DiseaseHistories");
            DropForeignKey("dbo.Notes", "Disease_Id", "dbo.Diseases");
            DropForeignKey("dbo.Diseases", "DiseaseStatus_Id", "dbo.DiseaseStatus");
            DropIndex("dbo.WorkDayDoctors", new[] { "WorkDay_Id" });
            DropIndex("dbo.WorkDayDoctors", new[] { "Doctor_Id" });
            DropIndex("dbo.Receptions", new[] { "MyProperty_Id" });
            DropIndex("dbo.Receptions", new[] { "Doctor_Id" });
            DropIndex("dbo.Receptions", new[] { "Id" });
            DropIndex("dbo.Diseases", new[] { "DiseaseStatus_Id" });
            DropIndex("dbo.Notes", new[] { "DiseaseHistory_Id" });
            DropIndex("dbo.Notes", new[] { "Disease_Id" });
            DropIndex("dbo.DiseaseHistories", new[] { "Id" });
            DropTable("dbo.Patients");
            DropTable("dbo.WorkDays");
            DropTable("dbo.WorkDayDoctors");
            DropTable("dbo.Doctors");
            DropTable("dbo.Receptions");
            DropTable("dbo.DiseaseStatus");
            DropTable("dbo.Diseases");
            DropTable("dbo.Notes");
            DropTable("dbo.DiseaseHistories");
        }
    }
}
