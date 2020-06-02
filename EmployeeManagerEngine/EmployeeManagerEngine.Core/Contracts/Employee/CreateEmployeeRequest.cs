using System;

namespace EmployeeManagerEngine.Model.Contracts.Employee
{
    public class CreateEmployeeRequest
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Born { get; set; }
        public string Email { get; set; }
        public int GenderId { get; set; }
        public int[] SkillIds { get; set; }
    }
}
