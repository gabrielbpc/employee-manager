using EmployeeManagerEngine.Core.Model;
using EmployeeManagerEngine.Interface.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagerEngine.Data.Command.Context
{
    public class EngineCommandContext : DbContext, IEngineCommandContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Skill> Skills { get; set; }

        public EngineCommandContext(DbContextOptions options): base(options)
        {
        }
    }
}
