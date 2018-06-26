using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using DataAccessLayer.Entities;
using System.Data.Entity;

namespace ConsoleApp1.DefaultData
{
    //клас для заповнення таблиць дефолтними даними
    class FillData      
    {
        public void FillAllTables()
        {
            FillDisStatuses();
            FillDiseases();
            FillDepartment();
            FillDoctors();

            FillWorkDays();
            FillWorkDaysDoctors();
        }

        public void FillDisStatuses()
        {
            GHRepository<DiseaseStatus> repository = new GHRepository<DiseaseStatus>();
            repository.AddRange(new List<DiseaseStatus> {
                new DiseaseStatus() { Code = "Закритий" },
                new DiseaseStatus() { Code = "Відкритий" },
                new DiseaseStatus() { Code = "Змінений" }
            });
        }
        public void FillDiseases()
        {
            GHRepository<Disease> repository = new GHRepository<Disease>();

            repository.AddRange(new List<Disease> {
                new Disease() {Name="Артрит", DiseaseStatusId=1},
                new Disease() {Name="Грип", DiseaseStatusId=2},
                new Disease() {Name="ГРВІ", DiseaseStatusId=3},
                new Disease() {Name="СПД", DiseaseStatusId=1},
                new Disease() {Name="Гайморит", DiseaseStatusId=2},
                new Disease() {Name="ВСД", DiseaseStatusId=3},
                new Disease() {Name="БЛО", DiseaseStatusId=1}
            });
        }
        public void FillDepartment()
        {
            GHRepository<Department> repository = new GHRepository<Department>();
            repository.Add(new Department() {Name="Назва Амбулаторія ЗПСМ №2", Address="Грушевського 2", Director="Біньковська О.Я." });
        }
        public void FillDoctors()
        {
            GHRepository<Doctor> repository = new GHRepository<Doctor>();

            repository.AddRange(new List<Doctor> {
                new Doctor() {Name="Чумак",Surname="Чумаченко"},
                new Doctor() {Name="Олеся",Surname="Біньковська"},
                new Doctor() {Name="Андрій",Surname="Шелевицький"},
                new Doctor() {Name="Олег",Surname="Титюк"},
                new Doctor() {Name="Ігор",Surname="Захарченко"},
                new Doctor() {Name="Наталія",Surname="Козак"}
            });
        }

        //public void FillDisHistories()
        //{
        //    GHRepository<DiseaseHistory> repository = new GHRepository<DiseaseHistory>();

        //    repository.AddRange(new List<DiseaseHistory>
        //    {
        //        new DiseaseHistory() {}
        //    });
        //}
        
        public void FillWorkDays()
        {
            GHRepository<WorkDay> repository = new GHRepository<WorkDay>();

            repository.AddRange(new List<WorkDay> {
                new WorkDay(){StartDate = new DateTime(2018,7,10,10,0,0), EndDate = new DateTime(2018,7,10,18,0,0)},
                new WorkDay(){StartDate = new DateTime(2018,7,10,12,0,0), EndDate = new DateTime(2018,7,10,20,0,0)},
                new WorkDay(){StartDate = new DateTime(2018,7,11,10,0,0), EndDate = new DateTime(2018,7,11,18,0,0)},
                new WorkDay(){StartDate = new DateTime(2018,7,11,12,0,0), EndDate = new DateTime(2018,7,10,20,0,0)}
            });
        }

        public void FillWorkDaysDoctors()
        {
            GHRepository<WorkDayDoctor> repository = new GHRepository<WorkDayDoctor>();

            repository.AddRange(new List<WorkDayDoctor> {
                new WorkDayDoctor(){DoctorId=1, WorkDayId=1},
                new WorkDayDoctor(){DoctorId=2, WorkDayId=2},
                new WorkDayDoctor(){DoctorId=3, WorkDayId=3},
                new WorkDayDoctor(){DoctorId=4, WorkDayId=4},
                new WorkDayDoctor(){DoctorId=5, WorkDayId=2},
                new WorkDayDoctor(){DoctorId=6, WorkDayId=3}
            });
        }
    }
}
