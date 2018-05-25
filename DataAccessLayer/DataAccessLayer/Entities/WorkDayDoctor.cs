using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class WorkDayDoctor
    {
        public int Id { get; set; }
        [Required]
        public Doctor Doctor { get; set; }
        [Required]
        public WorkDay WorkDay { get; set; }
    }
}
