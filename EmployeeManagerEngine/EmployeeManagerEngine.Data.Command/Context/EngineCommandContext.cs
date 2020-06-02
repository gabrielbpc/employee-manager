﻿using EmployeeManagerEngine.Data.Command.Mappings;
using EmployeeManagerEngine.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EmployeeManagerEngine.Data.Command.Context
{
    public class EngineCommandContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<EmployeeSkill> EmployeeSkills { get; set; }

        public DatabaseFacade DatabaseFacade => base.Database;

        public EngineCommandContext(DbContextOptions options): base(options)
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
