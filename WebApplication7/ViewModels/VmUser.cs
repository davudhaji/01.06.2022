using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.ViewModels
{
    public class VmUser
    {
        [MaxLength(30)]
        public string FullName { get; set; }

        [MaxLength(30)]
        public string UserName { get; set; }
        
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(30)]
        public string Password { get; set; }
    }
}
