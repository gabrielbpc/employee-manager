using EmployeeManagerEngine.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagerEngine.Data.Repositories
{
    public abstract class BaseRepository<TEntity> where TEntity : class
    {
        protected DbSet<TEntity> DbSet => _context.Set<TEntity>();
        private readonly EngineContext _context;

        protected BaseRepository(EngineContext commandContext) => _context = commandContext;

        public TEntity Save(TEntity entity)
        {
            var entry =  DbSet.Add(entity);

            SaveChanges();

            return entry.Entity;
        }

        public TEntity Update(TEntity entity)
        {
            var entry = DbSet.Update(entity);

            SaveChanges();

            return entry.Entity;
        }

        private void SaveChanges() => _context.SaveChanges();
    }
}
