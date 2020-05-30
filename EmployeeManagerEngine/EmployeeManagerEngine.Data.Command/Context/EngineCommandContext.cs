using EmployeeManagerEngine.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EmployeeManagerEngine.Data.Command.Context
{
    public class EngineCommandContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Skill> Skills { get; set; }

        public DatabaseFacade DatabaseFacade => base.Database;

        public EngineCommandContext(DbContextOptions options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EngineCommandContext).Assembly);
            modelBuilder.Entity<Employee>()
                        .HasMany(s => s.Skills)
                        .WithMany(c => c.)
                        .Map(cs =>
                        {
                            cs.MapLeftKey("StudentRefId");
                            cs.MapRightKey("CourseRefId");
                            cs.ToTable("StudentCourse");
                        });
        }
    }
}
