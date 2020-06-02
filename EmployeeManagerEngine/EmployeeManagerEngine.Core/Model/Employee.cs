using EmployeeManagerEngine.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmployeeManagerEngine.Model
{
    public class Employee : BaseModel
    {
        public Employee()
        {
            EmployeeSkills = new List<EmployeeSkill>();
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Born { get; set; }
        public string Email { get; set; }
        public int GenderId { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }

        private bool EmailIsInvalid()
        {
            if (string.IsNullOrWhiteSpace(Email))
                return false;

            var match = Regex.IsMatch(Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            
            return !match;
        }

        public void UpdateSkills(IEnumerable<Skill> skills)
        {
            EmployeeSkills.Clear();

            foreach (var skill in skills)
                EmployeeSkills.Add(EmployeeSkill.Create(Id, skill.Id));
        }

        public ValidationResult Validate()
        {
            var result = ValidationResult.Create();

            if (string.IsNullOrWhiteSpace(Name))
                result.Add(nameof(Name), "Nome invalido.");
            if (string.IsNullOrWhiteSpace(LastName))
                result.Add(nameof(LastName), "Sobrenome invalido.");
            if (Born == DateTime.MinValue)
                result.Add(nameof(Born), "Data de nascimento invalido.");
            if (EmailIsInvalid())
                result.Add(nameof(Email), "E-mail invalido.");
            if(GenderId == default)
                result.Add(nameof(GenderId), "Genero invalido.");
            if(!EmployeeSkills.Any())
                result.Add(nameof(EmployeeSkills), "Habilidades invalido.");

            return result;
        }
    }
}
