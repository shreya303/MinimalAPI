using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Minimal.Core.Entities;

namespace Minimal.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet for each entity
        public DbSet<Product> Products { get; set; }  // Example DbSet
    }
}
