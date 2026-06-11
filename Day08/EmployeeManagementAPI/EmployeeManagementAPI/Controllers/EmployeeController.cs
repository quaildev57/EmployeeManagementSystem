using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = new[]
            {
                new
                {
                    Id = 1,
                    Name = "Hrishita",
                    Department = "IT"
                },
                new
                {
                    Id = 2,
                    Name = "Rahul",
                    Department = "HR"
                }
            };

            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = new
            {
                Id = id,
                Name = "Hrishita",
                Department = "IT"
            };

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult CreateEmployee(Employee employee)
        {
            return Ok(employee);
        }

        [HttpGet("message")]
        public IActionResult GetMessage()
        {
            return Ok(_employeeService.GetMessage());
        }
    }
}