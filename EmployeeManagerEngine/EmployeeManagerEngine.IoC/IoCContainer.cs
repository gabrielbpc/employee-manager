using EmployeeManagerEngine.Data.Context;
using EmployeeManagerEngine.Data.Repositories;
using EmployeeManagerEngine.Interface.Repositories;
using EmployeeManagerEngine.Interface.Services;
using EmployeeManagerEngine.Service;
using EmployeeManagerEngine.Util.Mapper.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagerEngine.IoC
{
    public static class IoCContainer
    {
        public static void RegisterBindings(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<ISkillRepository, SkillRepository>();
            MapperConfiguration.Init();
        }

        public static void ConfigureCommandDB(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EngineContext>(opts => opts.UseSqlServer(connectionString), ServiceLifetime.Scoped);
        }
    }
}
