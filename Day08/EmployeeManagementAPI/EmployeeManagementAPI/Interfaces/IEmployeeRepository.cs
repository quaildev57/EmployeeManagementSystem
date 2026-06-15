using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();

        Employee GetEmployeeById(int id);

        int AddEmployee(Employee employee);

        int UpdateEmployee(Employee employee);

        int InactivateEmployee(int id);
    }
}