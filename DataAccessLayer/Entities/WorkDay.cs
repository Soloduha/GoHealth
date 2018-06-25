using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class WorkDay : IBaseEntity
    {
        public WorkDay()
        {
            WorkDayDoctor = new List<WorkDayDoctor>();
        }


        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        public ICollection<WorkDayDoctor> WorkDayDoctor { get; set; }

    }
}
