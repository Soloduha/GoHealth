using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class DiseaseStatus : IBaseEntity
    {
        public DiseaseStatus()
        {
            Disease = new List<Disease>();
        }


        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        public string Description { get; set; }

        public ICollection<Disease> Disease { get; set; }
    }
}
