using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Reception : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime DateOfRegistration { get; set; }
        [Required]
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public int NoteId { get; set; }
        public int NurseId { get; set; }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public Note Note { get; set; }
        public Nurse Nurse { get; set; }
    }
}
