using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Brewly_Backend.Data
{
    

    public class AppDbContext : DbContext
    {
        public DbSet<Coffee> Coffee { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
