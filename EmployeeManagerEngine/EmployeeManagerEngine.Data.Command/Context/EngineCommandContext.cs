using EmployeeManagerEngine.Data.Command.Mappings;
using EmployeeManagerEngine.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EmployeeManagerEngine.Data.Context
{
    public class EngineContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<EmployeeSkill> EmployeeSkills { get; set; }

        public DatabaseFacade DatabaseFacade => base.Database;

        public EngineContext(DbContextOptions options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeMapping());
            modelBuilder.ApplyConfiguration(new SkillMapping());
            modelBuilder.ApplyConfiguration(new GenderMapping());
            modelBuilder.ApplyConfiguration(new EmployeeSkillMapping());
        }
    }
}
