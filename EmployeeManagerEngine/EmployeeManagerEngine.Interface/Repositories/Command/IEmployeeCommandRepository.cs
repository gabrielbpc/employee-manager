using EmployeeManagerEngine.Interface.Base;
using EmployeeManagerEngine.Model;

namespace EmployeeManagerEngine.Interface.Repositories.Command
{
    public interface IEmployeeCommandRepository: IRepository
    {
        Employee Save(Employee employee);
        Employee Update(Employee employee);
    }
}
