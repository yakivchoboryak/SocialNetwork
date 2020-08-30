using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI.Models
{
    public class SocialNetworkContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public SocialNetworkContext(DbContextOptions<SocialNetworkContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
