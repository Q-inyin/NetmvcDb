using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        public string ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }

        public int Age { get; set; }

        [MaxLength(50)]
        public string Phone { get; set; }

        public string DepartmentID { get; set; }

        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
    }
}
