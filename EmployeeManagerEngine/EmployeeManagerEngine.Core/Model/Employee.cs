using System;
using System.Collections.Generic;

namespace EmployeeManagerEngine.Core.Model
{
    public class Employee : BaseModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Born { get; set; }
        public string Email { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
