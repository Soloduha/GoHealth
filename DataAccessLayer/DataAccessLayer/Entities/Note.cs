using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public string Medicine { get; set; }
        public Reception Reception { get; set; }
        public Disease Disease { get; set; }
        public DiseaseHistory DiseaseHistory { get; set; }
    }
}
