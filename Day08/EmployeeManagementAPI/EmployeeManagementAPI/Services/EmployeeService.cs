using EmployeeManagementAPI.Interfaces;
using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repositories;

namespace EmployeeManagementAPI.Services
{
    public class EmployeeService: IEmployeeService
    {

        private readonly IEmployeeRepository _repository;
        // Constructor injection of the repository through Dependency Injection
        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _repository.GetEmployees();
        }
        public string GetMessage()
        {
            return "Employee Service Working";
        }
        public Employee GetEmployeeById(int id)
        {
            return _repository.GetEmployeeById(id);
        }
        
        public int AddEmployee(Employee employee)
        {
            /*if(employee.Salary < 0)
            {
                return 0; 
                // Invalid salary, return 0 to indicate failure
                //this way, we get to see ki service layer is working and
                //also we can add some business logic here, like
                //validating the salary before adding the employee to the database.
                //and not just blindly forwarding the call to the repository layer.
            }
            return _repository.AddEmployee(employee);*/
            /* try
             {
                 if (employee.Salary < 0)
                     throw new Exception("Salary can't be negative.");
                 return _repository.AddEmployee(employee);
             }
             catch (Exception)
             {
                 throw;
             }*/
            //throw new Exception("Testing Middleware");

            return _repository.AddEmployee(employee);
        }
        
        public int UpdateEmployee(Employee employee)
        {
            return _repository.UpdateEmployee(employee);
        }

        public int InactivateEmployee(int id)
        {
            return _repository.InactivateEmployee(id);
        }
    }
}