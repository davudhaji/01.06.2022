using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Social
    {
        [Key]
        public int id { get; set; }

        public string Content { get; set; }

    }
}
