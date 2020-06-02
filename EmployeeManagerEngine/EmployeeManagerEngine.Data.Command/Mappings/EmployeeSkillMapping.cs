using EmployeeManagerEngine.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagerEngine.Data.Command.Mappings
{
    public class EmployeeSkillMapping : IEntityTypeConfiguration<EmployeeSkill>
    {
        public void Configure(EntityTypeBuilder<EmployeeSkill> builder)
        {
            builder
                .ToTable("EMPLOYEE_SKILL")
                .HasKey(key => new { key.EmployeeId, key.SkillId });

            builder.Property(p => p.SkillId).HasColumnName("skill_id");
            builder.Property(p => p.EmployeeId).HasColumnName("employee_id");

            builder.HasOne(p => p.Employee).WithMany(p => p.EmployeeSkills).HasForeignKey(fk => fk.EmployeeId);
            builder.HasOne(p => p.Skill).WithMany(p => p.EmployeeSkills).HasForeignKey(fk => fk.SkillId);
        }
    }
}
