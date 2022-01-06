using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public int Age { get; set; }
        [MaxLength(50)]
        public string Salary { get; set; }
        [ForeignKey("Position")]
        public int PositionId { get; set;}
    }
}
