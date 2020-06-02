using System;

namespace EmployeeManagerEngine.Model.DTO
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Born { get; set; }
        public string Email { get; set; }
        public DateTime LastModified { get; set; }
        public int GenderId { get; set; }
        public int[] SkillIds { get; set; }
    }
}
