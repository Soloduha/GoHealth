using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Doctor
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
        public string SecondName { get; set; }
        public string ThirdName { get; set; }

        public ICollection<WorkDayDoctor> WorkDayDoctor { get; set; }
        public ICollection<Reception> Reception { get; set; }
    }
}
