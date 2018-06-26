using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    interface IDataFiller
    {
        void FillAllTables();

        void FillDepartment();
        void FillDiseases();
        void FillDisHistories();
        void FIllDisStatuses();
        void FillDoctors();
        void FillNotes();
        void FillNurses();
        void FillPatients();
        void FillReceptions();
        void FillWorkDays();
        void FillWorkDayDoctors();
    }
}
