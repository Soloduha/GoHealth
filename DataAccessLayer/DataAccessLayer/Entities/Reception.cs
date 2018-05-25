﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Reception
    {
        public int Id { get; set; }
        public DateTime DateOfRegistration { get; set; }
        [Required]
        public Doctor Doctor { get; set; }
        [Required]
        public Patient Patient { get; set; }
        public Note Note { get; set; }
    }
}
