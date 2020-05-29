using EmployeeManagerEngine.Core.Services;
using EmployeeManagerEngine.Data.Command.Context;
using EmployeeManagerEngine.Data.Command.Repositories;
using EmployeeManagerEngine.Interface.Repositories.Command;
using EmployeeManagerEngine.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EmployeeManagerEngine.IoC
{
    public static class IoCContainer
    {
        public static void RegisterBindings(this IServiceCollection services)
        {
            var assemblies = AssemblyGenerator.GetAssemblies();

            services.AddDbContext<EngineCommandContext>(opts => opts.UseSqlServer());
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IEmployeeCommandRepository, EmployeeCommandRepository>();
        }


        public static void RegisterAllTypes<T>(IServiceCollection services, IEnumerable<Assembly> assemblies, ServiceLifetime lifetime = ServiceLifetime.Transient)
        {
            //RegisterAllTypes<IService>(serviceCollection, assemblies);
            //RegisterAllTypes<IRepository>(serviceCollection, assemblies);
            var typesFromAssemblies = assemblies.SelectMany(a => a.DefinedTypes.Where(x => x.GetInterfaces().Contains(typeof(T))));
            foreach (var type in typesFromAssemblies)
                services.Add(new ServiceDescriptor(typeof(T), type, lifetime));
        }
    }
}
