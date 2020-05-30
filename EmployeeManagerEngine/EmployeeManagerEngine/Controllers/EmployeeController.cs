using EmployeeManagerEngine.Mediator;
using EmployeeManagerEngine.Mediator.Commands.Employee;
using EmployeeManagerEngine.Model.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeManagerEngine.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediatorHandler _mediator;
        public EmployeeController(IMediatorHandler mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            var create = new CreateEmployeeCommand();
            var result = await _mediator.SendCommand<CreateEmployeeCommand, EmployeeDto>(create);
            
            return Ok();
        }

    }
}