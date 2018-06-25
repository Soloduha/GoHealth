namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Director = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        ThirdName = c.String(),
                        Password = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Receptions",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DateOfRegistration = c.DateTime(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        NoteId = c.Int(nullable: false),
                        NurseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .ForeignKey("dbo.Notes", t => t.Id)
                .ForeignKey("dbo.Nurses", t => t.NurseId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.DoctorId)
                .Index(t => t.PatientId)
                .Index(t => t.NurseId);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Medicine = c.String(),
                        ReceptionId = c.Int(nullable: false),
                        DiseaseId = c.Int(nullable: false),
                        DiseaseHistoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Diseases", t => t.DiseaseId, cascadeDelete: true)
                .ForeignKey("dbo.DiseaseHistories", t => t.DiseaseHistoryId, cascadeDelete: true)
                .Index(t => t.DiseaseId)
                .Index(t => t.DiseaseHistoryId);
            
            CreateTable(
                "dbo.Diseases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DiseaseStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DiseaseStatus", t => t.DiseaseStatusId, cascadeDelete: true)
                .Index(t => t.DiseaseStatusId);
            
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
                "dbo.DiseaseHistories",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        ThirdName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        DiseaseHistoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nurses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SecondName = c.String(nullable: false),
                        ThirdName = c.String(),
                        Password = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkDayDoctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoctorId = c.Int(nullable: false),
                        WorkDayId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.WorkDays", t => t.WorkDayId, cascadeDelete: true)
                .Index(t => t.DoctorId)
                .Index(t => t.WorkDayId);
            
            CreateTable(
                "dbo.WorkDays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkDayDoctors", "WorkDayId", "dbo.WorkDays");
            DropForeignKey("dbo.WorkDayDoctors", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Receptions", "NurseId", "dbo.Nurses");
            DropForeignKey("dbo.Receptions", "Id", "dbo.Notes");
            DropForeignKey("dbo.Receptions", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.DiseaseHistories", "Id", "dbo.Patients");
            DropForeignKey("dbo.Notes", "DiseaseHistoryId", "dbo.DiseaseHistories");
            DropForeignKey("dbo.Notes", "DiseaseId", "dbo.Diseases");
            DropForeignKey("dbo.Diseases", "DiseaseStatusId", "dbo.DiseaseStatus");
            DropForeignKey("dbo.Receptions", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.WorkDayDoctors", new[] { "WorkDayId" });
            DropIndex("dbo.WorkDayDoctors", new[] { "DoctorId" });
            DropIndex("dbo.DiseaseHistories", new[] { "Id" });
            DropIndex("dbo.Diseases", new[] { "DiseaseStatusId" });
            DropIndex("dbo.Notes", new[] { "DiseaseHistoryId" });
            DropIndex("dbo.Notes", new[] { "DiseaseId" });
            DropIndex("dbo.Receptions", new[] { "NurseId" });
            DropIndex("dbo.Receptions", new[] { "PatientId" });
            DropIndex("dbo.Receptions", new[] { "DoctorId" });
            DropIndex("dbo.Receptions", new[] { "Id" });
            DropIndex("dbo.Doctors", new[] { "DepartmentId" });
            DropTable("dbo.WorkDays");
            DropTable("dbo.WorkDayDoctors");
            DropTable("dbo.Nurses");
            DropTable("dbo.Patients");
            DropTable("dbo.DiseaseHistories");
            DropTable("dbo.DiseaseStatus");
            DropTable("dbo.Diseases");
            DropTable("dbo.Notes");
            DropTable("dbo.Receptions");
            DropTable("dbo.Doctors");
            DropTable("dbo.Departments");
        }
    }
}
