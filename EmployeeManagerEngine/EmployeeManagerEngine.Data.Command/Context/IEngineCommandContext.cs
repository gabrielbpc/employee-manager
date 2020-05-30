using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EmployeeManagerEngine.Data.Command.Context
{
    public interface IEngineCommandContext
    {
        DatabaseFacade DatabaseFacade { get; }
        int SaveChanges();
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
