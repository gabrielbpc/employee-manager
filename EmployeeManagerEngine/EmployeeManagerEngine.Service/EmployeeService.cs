using EmployeeManagerEngine.Interface.Repositories;
using EmployeeManagerEngine.Interface.Services;
using EmployeeManagerEngine.Model;
using EmployeeManagerEngine.Model.DTO;
using EmployeeManagerEngine.Util.Mapper;
using System;
using System.Linq;

namespace EmployeeManagerEngine.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ISkillRepository _skillRepository;

        public EmployeeService(IEmployeeRepository employeeRepository, ISkillRepository skillRepository)
        {
            _employeeRepository = employeeRepository;
            _skillRepository = skillRepository;
        }

        public EmployeeDto Create(EmployeeDto dto)
        {
            var employee = dto.MapTo<EmployeeDto, Employee>();

            UpdateSkills(dto, employee);

            var validationResult = employee.Validate();

            if (validationResult.IsInvalid)
                throw new InvalidOperationException(validationResult.ToExceptionString());

            employee = _employeeRepository.Save(employee);

            return employee.MapTo<Employee, EmployeeDto>();
        }

        public EmployeeDto Update(EmployeeDto dto)
        {
            var employee = dto.MapTo<EmployeeDto, Employee>();

            if (NotExistReferralIds(dto))
                throw new InvalidOperationException("Ids Invalidos");

            UpdateSkills(dto, employee);

            var validationResult = employee.Validate();

            if (validationResult.IsInvalid)
                throw new InvalidOperationException(validationResult.ToExceptionString());

            employee.UpdateLastModifiedDate();
            employee = _employeeRepository.Update(employee);

            return employee.MapTo<Employee, EmployeeDto>();
        }

        private bool NotExistReferralIds(EmployeeDto dto) => !(_employeeRepository.Exists(dto.Id) || _skillRepository.Exists(dto.SkillIds));

        private void UpdateSkills(EmployeeDto dto, Employee employee)
        {
            var skills = _skillRepository.Get(dto.SkillIds).ToList();

            employee.UpdateSkills(skills);
        }
    }
}
