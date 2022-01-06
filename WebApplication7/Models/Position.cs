using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Position
    {
        [Key]
        public int id { get; set; }

        [MaxLength(50)]
        public string PositionName { get; set; }

        public List<Employee> Employees = new List<Employee>();

    }
}
