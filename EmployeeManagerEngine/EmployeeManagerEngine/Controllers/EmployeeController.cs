using EmployeeManagerEngine.Interface.Services;
using EmployeeManagerEngine.Model.Contracts.Employee;
using EmployeeManagerEngine.Model.DTO;
using EmployeeManagerEngine.Util.Mapper;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EmployeeManagerEngine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create([FromServices] IEmployeeService employeeService, CreateEmployeeRequest request)
        {
            try
            {
                var createDto = request.MapTo<CreateEmployeeRequest, EmployeeDto>();
                var result = employeeService.Create(createDto);

                return Ok(result);

            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromServices] IEmployeeService employeeService, UpdateEmployeeRequest request)
        {
            try
            {
                var createDto = request.MapTo<UpdateEmployeeRequest, EmployeeDto>();
                var result = employeeService.Update(createDto);

                return Ok(result);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok();
        }
    }
}