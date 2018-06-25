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
    }
}
