using EmployeeManagerEngine.Interface.Base;
using EmployeeManagerEngine.Model;

namespace EmployeeManagerEngine.Interface.Repositories
{
    public interface IEmployeeRepository : IRepository
    {
        Employee Save(Employee employee);
        Employee Update(Employee employee);
        bool Exists(int id);
    }
}
