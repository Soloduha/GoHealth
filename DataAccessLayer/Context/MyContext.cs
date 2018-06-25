namespace DataAccessLayer.Context
{
    using DataAccessLayer.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyContext : DbContext
    {
        public MyContext()
            : base("name=GoHealthString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .HasOptional(s => s.DiseaseHistory) // Mark Address property optional in Student entity
                .WithRequired(ad => ad.Patient);

            modelBuilder.Entity<Note>()
                .HasOptional(s => s.Reception) // Mark Address property optional in Student entity
                .WithRequired(ad => ad.Note);
        }

        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<DiseaseHistory> DiseaseHistories { get; set; }
        public virtual DbSet<DiseaseStatus> DiseaseStatuses { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Reception> Receptions { get; set; }
        public virtual DbSet<WorkDay> WorkDays { get; set; }
        public virtual DbSet<WorkDayDoctor> WorkDayDoctors { get; set; }
        public virtual DbSet<Nurse> Nurses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}