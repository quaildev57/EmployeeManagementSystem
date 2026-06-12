using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository _repository;

        public EmployeeController(EmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = _repository.GetEmployees();

            return Ok(employees);
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _repository.GetEmployeeById(id);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            int rows = _repository.AddEmployee(employee);

            if (rows > 0)
                return Ok("Employee Added Successfully");

            return BadRequest();
        }
        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
            int rows = _repository.UpdateEmployee(employee);

            if (rows > 0)
                return Ok("Employee Updated Successfully");

            return BadRequest();
        }
        [HttpPut("inactivate/{id}")]
        public IActionResult InactivateEmployee(int id)
        {
            int rows = _repository.InactivateEmployee(id);

            if (rows > 0)
                return Ok("Employee Inactivated");

            return BadRequest();
        }
    }
}