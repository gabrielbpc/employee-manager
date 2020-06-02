using EmployeeManagerEngine.Data.Command.Context;
using EmployeeManagerEngine.Interface.Repositories.Command;
using EmployeeManagerEngine.Model;

namespace EmployeeManagerEngine.Data.Command.Repositories
{
    public class EmployeeCommandRepository : BaseRepository<Employee>, IEmployeeCommandRepository
    {
        public EmployeeCommandRepository(EngineCommandContext context) : base(context) { }
    }
}
