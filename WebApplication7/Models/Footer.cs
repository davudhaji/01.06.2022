using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Footer
    {
        [Key]
        public int id { get; set; }

        public string Title { get; set; }

        public string Adress { get; set; }
        public string Email { get; set; }


    }
}
