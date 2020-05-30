using EmployeeManagerEngine.Core.Model;
using EmployeeManagerEngine.Data.Command.Context;
using EmployeeManagerEngine.Interface.Repositories.Command;

namespace EmployeeManagerEngine.Data.Command.Repositories
{
    public class EmployeeCommandRepository : BaseRepository<Employee>, IEmployeeCommandRepository
    {
        public EmployeeCommandRepository(EngineCommandContext context) : base(context) { }
    }
}
