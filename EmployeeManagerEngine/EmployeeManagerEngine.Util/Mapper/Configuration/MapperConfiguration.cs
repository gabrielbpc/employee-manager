using AutoMapper;
using EmployeeManagerEngine.Util.Mapper.Profiles;

namespace EmployeeManagerEngine.Util.Mapper.Configuration
{
    public static class MapperConfiguration
    {
        internal static IMapper Mapper { get; private set; }
        
        private static readonly object ConcurrentLock = new object();
        private static bool Initialized = false;

        public static void Init()
        {
            if (!Initialized)
            {
                lock (ConcurrentLock)
                {
                    var mapperConfiguration = new AutoMapper.MapperConfiguration(config => 
                    {
                        config.AddProfile<EmployeeProfile>();
                    });

                    Mapper = mapperConfiguration.CreateMapper();
                }
            }
        }
    }
}
