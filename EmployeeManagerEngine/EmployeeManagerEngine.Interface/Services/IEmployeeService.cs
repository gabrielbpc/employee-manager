using EmployeeManagerEngine.Interface.Base;
using EmployeeManagerEngine.Model.DTO;

namespace EmployeeManagerEngine.Interfaces.Services
{
    public interface IEmployeeService : IService
    {
        EmployeeDto Create(EmployeeDto dto);
        EmployeeDto Update(EmployeeDto dto);
    }
}
