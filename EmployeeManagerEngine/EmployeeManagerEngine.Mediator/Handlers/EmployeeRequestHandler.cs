using EmployeeManagerEngine.Interfaces.Services;
using EmployeeManagerEngine.Mediator.Commands.Employee;
using EmployeeManagerEngine.Model.DTO;
using EmployeeManagerEngine.Util.Mapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagerEngine.Mediator.Handlers
{
    public class EmployeeRequestHandler : IRequestHandler<CreateEmployeeCommand, EmployeeDto>
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeRequestHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public Task<EmployeeDto> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {

            var dto = request.MapTo<CreateEmployeeCommand, EmployeeDto>();
            var result = _employeeService.Create(dto);

            return Task.FromResult(result);
        }
    }
}
