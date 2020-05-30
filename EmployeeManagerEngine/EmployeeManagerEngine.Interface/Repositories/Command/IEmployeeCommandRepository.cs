using EmployeeManagerEngine.Core.Model;
using EmployeeManagerEngine.Interface.Base;

namespace EmployeeManagerEngine.Interface.Repositories.Command
{
    public interface IEmployeeCommandRepository: IRepository
    {
        Employee Save(Employee employee);
        Employee Update(Employee employee);
    }
}
