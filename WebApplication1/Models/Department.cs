﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Department
    {
        [Key]
        public string ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
