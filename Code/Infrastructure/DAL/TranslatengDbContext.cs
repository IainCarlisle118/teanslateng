using Microsoft.EntityFrameworkCore;
using Data.Entities;
using System.Diagnostics.Tracing;
using System.Reflection;

namespace Infrastructure.DAL
{
    public class TranslatengDbContext : DbContext
    {
        public TranslatengDbContext(DbContextOptions<TranslatengDbContext> options) : base(options)
        {
        }

        public DbSet<Languages> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}