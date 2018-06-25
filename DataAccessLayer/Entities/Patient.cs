using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Patient : IBaseEntity
    {
        public Patient()
        {
            Reception = new List<Reception>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ThirdName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DiseaseHistoryId { get; set; }

        public DiseaseHistory DiseaseHistory { get; set; }

        public ICollection<Reception> Reception { get; set; }


    }
}
