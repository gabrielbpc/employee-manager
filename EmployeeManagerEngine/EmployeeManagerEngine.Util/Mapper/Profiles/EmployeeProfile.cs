using AutoMapper;
using EmployeeManagerEngine.Model;
using EmployeeManagerEngine.Model.Contracts.Employee;
using EmployeeManagerEngine.Model.DTO;
using System.Linq;

namespace EmployeeManagerEngine.Util.Mapper.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeDto, Employee>()
                .ReverseMap()
                .ForMember(source => source.SkillIds, opt => opt.MapFrom(source => source.EmployeeSkills.Select(p => p.SkillId)));
            CreateMap<CreateEmployeeRequest, EmployeeDto>()
                .ReverseMap();
           
            CreateMap<UpdateEmployeeRequest, EmployeeDto>().ReverseMap();
        }
    }
}
