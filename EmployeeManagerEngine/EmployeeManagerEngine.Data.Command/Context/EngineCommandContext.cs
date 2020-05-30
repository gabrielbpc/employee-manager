﻿using EmployeeManagerEngine.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EmployeeManagerEngine.Data.Command.Context
{
    public class EngineCommandContext : DbContext, IEngineCommandContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Skill> Skills { get; set; }

        public DatabaseFacade DatabaseFacade => base.Database;

        public EngineCommandContext(DbContextOptions options): base(options)
        {
        }
    }
}
