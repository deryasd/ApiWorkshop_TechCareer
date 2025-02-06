using APIWorkshopTechCareerProject.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace APIWorkshopTechCareerProject.DataAccess.Data
{
    public class TechCareerDbContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "Context";

        public TechCareerDbContext(DbContextOptions<TechCareerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().ToTable("User");

            base.OnModelCreating(builder);
        }
        public DbSet<User> Users { get; set; }
    }
}
