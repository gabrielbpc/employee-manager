using EmployeeManagerEngine.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagerEngine.Data.Command.Context
{
    public class EngineCommandContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Skill> Skills { get; set; }

        public EngineCommandContext(DbContextOptions options): base(options)
        {
        }
    }
}
