using BLL.Interfaces;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DefData
{
    public class CodeDataFiller : IDataFiller
    {


        public void FillAllTables()
        {
            FIllDisStatuses();
            FillDiseases();
            FillDepartment();
            FillDoctors();

            FillWorkDays();
            FillWorkDayDoctors();
            FillNurses();
            FillDisHistories();
            FillPatients();
        }
        
        public void FillDepartment()
        {
            IDataRepository<Department> repository = new GHRepository<Department>();
            repository.Add(new Department() { Name = "Назва Амбулаторія ЗПСМ №2", Address = "Грушевського 2", Director = "Біньковська О.Я." });
        }

        public void FillDiseases()
        {
            IDataRepository<Disease> repository = new GHRepository<Disease>();

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

        public void FillDisHistories()
        {
            IDataRepository<DiseaseHistory> repository = new GHRepository<DiseaseHistory>();
            repository.AddRange(new List<DiseaseHistory> {
                new DiseaseHistory{Name="Історія хвороб №1",PatientId=1},
                new DiseaseHistory{Name="Історія хвороб №2",PatientId=2},
                new DiseaseHistory{Name="Історія хвороб №3",PatientId=3},
                new DiseaseHistory{Name="Історія хвороб №4",PatientId=4},
                new DiseaseHistory{Name="Історія хвороб №5",PatientId=5},
                new DiseaseHistory{Name="Історія хвороб №6",PatientId=6},
                new DiseaseHistory{Name="Історія хвороб №7",PatientId=7}
            });
        }

        public void FIllDisStatuses()
        {
            IDataRepository<DiseaseStatus> repository = new GHRepository<DiseaseStatus>();
            repository.AddRange(new List<DiseaseStatus> {
                new DiseaseStatus() { Code = "Закритий" },
                new DiseaseStatus() { Code = "Відкритий" },
                new DiseaseStatus() { Code = "Змінений" }
            });
        }

        public void FillDoctors()
        {
            IDataRepository<Doctor> repository = new GHRepository<Doctor>();

            repository.AddRange(new List<Doctor> {
                new Doctor() {Name="Чумак",Surname="Чумаченко"},
                new Doctor() {Name="Олеся",Surname="Біньковська"},
                new Doctor() {Name="Андрій",Surname="Шелевицький"},
                new Doctor() {Name="Олег",Surname="Титюк"},
                new Doctor() {Name="Ігор",Surname="Захарченко"},
                new Doctor() {Name="Наталія",Surname="Козак"}
            });
        }

        public void FillNotes()
        {
            IDataRepository<Note> repository = new GHRepository<Note>();

            repository.AddRange(new List<Note> {
                new Note() {Medicine="Some medicines",ReceptionId=1, DiseaseId=1,DiseaseHistoryId=1},
                new Note() {Medicine="Some medicines",ReceptionId=1, DiseaseId=3,DiseaseHistoryId=2},
                new Note() {Medicine="Some medicines",ReceptionId=1, DiseaseId=4,DiseaseHistoryId=3},
                new Note() {Medicine="Some medicines",ReceptionId=1, DiseaseId=7,DiseaseHistoryId=4},
                new Note() {Medicine="Some medicines",ReceptionId=1, DiseaseId=6,DiseaseHistoryId=5},
                new Note() {Medicine="Some medicines",ReceptionId=1, DiseaseId=5,DiseaseHistoryId=6},
                new Note() {Medicine="Some medicines",ReceptionId=1, DiseaseId=2,DiseaseHistoryId=7}
            });
        }

        public void FillNurses()
        {
            IDataRepository<Nurse> repository = new GHRepository<Nurse>();

            repository.AddRange(new List<Nurse> {
                new Nurse() {Name="Галина",SecondName="Добряк", ThirdName="Іванівна",
                Password="12345Dobriak", PhoneNumber="0935672865"},
                new Nurse() {Name="Надія", SecondName="Бойко",  ThirdName="Володимирівна",
                Password="12345Boyko", PhoneNumber="0678934678"},
                new Nurse() {Name="Ірина", SecondName="Цурко",  ThirdName="Степанівна",
                Password="12345Tsurko", PhoneNumber="0508345782"}
            });
        }

        public void FillReceptions()
        {
            throw new NotImplementedException();
        }

        public void FillWorkDayDoctors()
        {
            IDataRepository<WorkDayDoctor> repository = new GHRepository<WorkDayDoctor>();

            repository.AddRange(new List<WorkDayDoctor> {
                new WorkDayDoctor(){DoctorId=1, WorkDayId=1},
                new WorkDayDoctor(){DoctorId=2, WorkDayId=2},
                new WorkDayDoctor(){DoctorId=3, WorkDayId=3},
                new WorkDayDoctor(){DoctorId=4, WorkDayId=4},
                new WorkDayDoctor(){DoctorId=5, WorkDayId=2},
                new WorkDayDoctor(){DoctorId=6, WorkDayId=3}
            });
        }

        public void FillWorkDays()
        {
            IDataRepository<WorkDay> repository = new GHRepository<WorkDay>();

            repository.AddRange(new List<WorkDay> {
                new WorkDay(){StartDate = new DateTime(2018,7,10,10,0,0), EndDate = new DateTime(2018,7,10,18,0,0)},
                new WorkDay(){StartDate = new DateTime(2018,7,10,12,0,0), EndDate = new DateTime(2018,7,10,20,0,0)},
                new WorkDay(){StartDate = new DateTime(2018,7,11,10,0,0), EndDate = new DateTime(2018,7,11,18,0,0)},
                new WorkDay(){StartDate = new DateTime(2018,7,11,12,0,0), EndDate = new DateTime(2018,7,10,20,0,0)}
            });
        }

        public void FillPatients()
        {
            IDataRepository<Patient> repository = new GHRepository<Patient>();

            repository.AddRange(new List<Patient> {
                new Patient(){Name="Влад",Surname="Віктюк",ThirdName="Вікторович",DateOfBirth=new DateTime(1988,10,10),DiseaseHistoryId=7},
                new Patient(){Name="Олександр",Surname="Петриченко",ThirdName="Валентинович",DateOfBirth=new DateTime(1975,8,3),DiseaseHistoryId=6},
                new Patient(){Name="Богдан",Surname="Гупало",ThirdName="Олегович",DateOfBirth=new DateTime(1985,11,28),DiseaseHistoryId=5},
                new Patient(){Name="Віктор",Surname="Степанюк",ThirdName="Іллевич",DateOfBirth=new DateTime(1996,2,15),DiseaseHistoryId=4},
                new Patient(){Name="Петро",Surname="Ломаченко",ThirdName="Валерійович",DateOfBirth=new DateTime(2001,3,22),DiseaseHistoryId=3},
                new Patient(){Name="Дарина",Surname="Петриченко",ThirdName="Костянтинівна",DateOfBirth=new DateTime(1993,10,12),DiseaseHistoryId=2},
                new Patient(){Name="Софія",Surname="Бабич",ThirdName="Альбертівна",DateOfBirth=new DateTime(1982,7,11),DiseaseHistoryId=1}
            });
        }
    }
}
