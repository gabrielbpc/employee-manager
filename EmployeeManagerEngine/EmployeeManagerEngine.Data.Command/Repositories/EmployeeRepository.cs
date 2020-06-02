using EmployeeManagerEngine.Data.Context;
using EmployeeManagerEngine.Interface.Repositories;
using EmployeeManagerEngine.Model;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace EmployeeManagerEngine.Data.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EngineContext context) : base(context) { }

        public bool Exists(int id) => DbSet.Any(x => x.Id == id);
    }
}
