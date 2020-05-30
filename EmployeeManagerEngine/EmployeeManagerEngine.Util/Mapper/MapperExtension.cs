using EmployeeManagerEngine.Util.Mapper.Configuration;

namespace EmployeeManagerEngine.Util.Mapper
{
    public static class MapperExtension
    {
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            return MapperConfiguration.Mapper.Map<TSource, TDestination>(source);
        }
    }
}
