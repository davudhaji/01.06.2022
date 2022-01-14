using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.Data
{
    public class AppContext: IdentityDbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<CustomUser> customUsers { get; set; }

        public DbSet<Social> socials { get; set; }
        
        public DbSet<Footer> footers { get; set; }

        public DbSet<SocialIcons> socialIcons { get; set; }
        public DbSet<Topbar> Topbars { get; set; }

    }
}
