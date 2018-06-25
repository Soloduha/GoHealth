using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class DiseaseHistory : IBaseEntity
    {
        public DiseaseHistory()
        {
            Note = new List<Note>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int PatientId { get; set; }

        public Patient Patient { get; set; }

        public ICollection<Note> Note { get; set; }
    }
}
