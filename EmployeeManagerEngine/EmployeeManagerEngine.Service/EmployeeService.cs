using EmployeeManagerEngine.Interface.Repositories.Command;
using EmployeeManagerEngine.Interfaces.Services;

namespace EmployeeManagerEngine.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeCommandRepository _employeeRepository;

        public EmployeeService(IEmployeeCommandRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


    }
}
