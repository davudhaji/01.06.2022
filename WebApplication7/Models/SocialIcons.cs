using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class SocialIcons
    {
        [Key]
        public int id { get; set; }

        public string Icon { get; set; }

        public string SocialLink { get; set; }

    }
}
