using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Note : IBaseEntity
    {
        public int Id { get; set; }
        public string Medicine { get; set; }
        public int ReceptionId { get; set; }
        public int DiseaseId { get; set; }
        public int DiseaseHistoryId { get; set; }

        public Reception Reception { get; set; }
        public Disease Disease { get; set; }
        public DiseaseHistory DiseaseHistory { get; set; }
    }
}
