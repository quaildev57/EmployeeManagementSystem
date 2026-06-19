using EmployeeManagementAPI.Interfaces;
using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repositories;
using EmployeeManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    //had the inherited class been Controller: that is an MVC controller,
    //it would have been used to return views, but since we are building
    //an API, we will inherit from ControllerBase which is used for APIs and
    //does not have view support.

    [Authorize]
    public class EmployeeController : ControllerBase
    {
        /*private readonly EmployeeRepository _repository;
        public EmployeeController(EmployeeRepository repository)
        {
            _repository = repository;
        }
        */
        //now this is not needed as we will inject the service instead of the repository

        private readonly IEmployeeService _service;
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(IEmployeeService service, ILogger<EmployeeController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            Console.WriteLine("GET API HIT");
            //var employees = _service.GetEmployees();
            _logger.LogInformation("GetEmployees API called");
            return Ok(_service.GetEmployees());
        }
        
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _service.GetEmployeeById(id);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            //try
            //{
                int rows = _service.AddEmployee(employee);
                //if (rows > 0)
                  return Ok("Employee Added Successfully");
            //}
            //catch (Exception ex)
            //{
                //return BadRequest(ex.Message);
           // }

        }

        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
            int rows = _service.UpdateEmployee(employee);

            if (rows > 0)
                return Ok("Employee Updated Successfully");

            return BadRequest();
        }
        [HttpPut("inactivate/{id}")]
        public IActionResult InactivateEmployee(int id)
        {

            int rows = _service.InactivateEmployee(id);

            if (rows > 0)
                return Ok("Employee Inactivated");

            return BadRequest();
        }
    }
}