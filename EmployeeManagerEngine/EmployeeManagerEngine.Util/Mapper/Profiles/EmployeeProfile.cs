using AutoMapper;
using EmployeeManagerEngine.Model;
using EmployeeManagerEngine.Model.Contracts.Employee;
using EmployeeManagerEngine.Model.DTO;

namespace EmployeeManagerEngine.Util.Mapper.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeDto, Employee>().ReverseMap();
            CreateMap<CreateEmployeeRequest, EmployeeDto>().ReverseMap();
        }
    }
}
