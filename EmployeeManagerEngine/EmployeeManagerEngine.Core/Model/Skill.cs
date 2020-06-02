using System.Collections.Generic;

namespace EmployeeManagerEngine.Model
{
    public class Skill : BaseModel
    {
        public string Description { get; set; }
        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
