using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EmployeeManagerEngine.Model
{
    public class Employee : BaseModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Born { get; set; }
        public string Email { get; set; }
        public int GenderId { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }

        public bool EmailIsInvalid()
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Email);
            
            return match.Success;
        }
    }
}
