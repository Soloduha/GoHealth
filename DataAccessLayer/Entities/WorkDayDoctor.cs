using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class WorkDayDoctor : IBaseEntity
    {
        public int Id { get; set; }
        [Required]
        public int DoctorId { get; set; }
        public int WorkDayId { get; set; }

        public Doctor Doctor { get; set; }
        public WorkDay WorkDay { get; set; }
    }
}
