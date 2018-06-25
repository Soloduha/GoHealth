using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Doctor : IBaseEntity
    {
        public Doctor()
        {
            WorkDayDoctor = new List<WorkDayDoctor>();
            Reception = new List<Reception>();
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string ThirdName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        public ICollection<WorkDayDoctor> WorkDayDoctor { get; set; }
        public ICollection<Reception> Reception { get; set; }
    }
}
