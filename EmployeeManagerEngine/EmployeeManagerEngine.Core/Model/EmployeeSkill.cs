namespace EmployeeManagerEngine.Model
{
    public class EmployeeSkill
    {
        public EmployeeSkill(int employeeId, int skillId)
        {
            EmployeeId = employeeId;
            SkillId = skillId;
        }
        public int EmployeeId { get; set; }
        public int SkillId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Skill Skill { get; set; }

        public static EmployeeSkill Create(int employeeId, int skillId) => new EmployeeSkill(employeeId, skillId);
    }
}
