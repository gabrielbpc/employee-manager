using EmployeeManagerEngine.Data.Context;
using EmployeeManagerEngine.Interface.Repositories;
using EmployeeManagerEngine.Model;
using System.Linq;

namespace EmployeeManagerEngine.Data.Repositories
{
    public class SkillRepository : BaseRepository<Skill>, ISkillRepository
    {
        public SkillRepository(EngineContext commandContext) : base(commandContext)
        {
        }

        public bool Exists(int[] skillIds) => DbSet.Any(x => skillIds.Contains(x.Id));

        public IQueryable<Skill> Get(int[] ids)
        {
            return DbSet.Where(skill => ids.Contains(skill.Id));
        }
    }
}
