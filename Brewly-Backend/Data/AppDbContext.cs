using System.Collections.Generic;
using Brewly_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Brewly_Backend.Data
{


    public class AppDbContext : DbContext
    {
        

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Coffee> Coffee { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
