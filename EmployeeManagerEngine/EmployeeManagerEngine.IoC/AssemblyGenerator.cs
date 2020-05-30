using EmployeeManagerEngine.Service;
using EmployeeManagerEngine.Data.Command.Repositories;
using System.Collections.Generic;
using System.Reflection;

namespace EmployeeManagerEngine.IoC
{
    public static class AssemblyGenerator
    {
        public static IEnumerable<Assembly> GetAssemblies()
        {
            yield return typeof(EmployeeService).Assembly;
            yield return typeof(EmployeeCommandRepository).Assembly;
        }
    }
}
