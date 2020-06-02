using EmployeeManagerEngine.Interface.Base;
using EmployeeManagerEngine.Model;
using System.Linq;

namespace EmployeeManagerEngine.Interface.Repositories
{
    public interface ISkillRepository : IRepository
    {
        IQueryable<Skill> Get(int[] ids);
        bool Exists(int[] skillIds);
    }
}
