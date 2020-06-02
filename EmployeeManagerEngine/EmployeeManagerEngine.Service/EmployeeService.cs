using EmployeeManagerEngine.Interface.Repositories.Command;
using EmployeeManagerEngine.Interface.Services;
using EmployeeManagerEngine.Model;
using EmployeeManagerEngine.Model.DTO;
using EmployeeManagerEngine.Util.Mapper;
using System;

namespace EmployeeManagerEngine.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeCommandRepository _employeeRepository;

        public EmployeeService(IEmployeeCommandRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public EmployeeDto Create(EmployeeDto dto)
        {
            var employee = dto.MapTo<EmployeeDto, Employee>();

            if (employee.EmailIsInvalid())
                throw new InvalidOperationException("Invalid email");

            employee = _employeeRepository.Save(employee);

            return employee.MapTo<Employee, EmployeeDto>();
        }

        public EmployeeDto Update(EmployeeDto dto)
        {
            var employee = dto.MapTo<EmployeeDto, Employee>();

            employee.UpdateLastModifiedDate();
            employee = _employeeRepository.Update(employee);

            return employee.MapTo<Employee, EmployeeDto>();
        }
    }
}
