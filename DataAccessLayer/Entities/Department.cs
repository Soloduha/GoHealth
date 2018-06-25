using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Department:IBaseEntity
    {
        public Department()
        {
            Doctor = new List<Doctor>();
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public string Director { get; set; }

        public ICollection<Doctor> Doctor { get; set; }
    }
}
