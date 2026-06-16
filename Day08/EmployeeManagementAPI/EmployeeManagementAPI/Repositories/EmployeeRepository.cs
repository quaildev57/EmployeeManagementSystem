using Dapper;
using Microsoft.Data.SqlClient;
using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Interfaces;
using System.Data;

namespace EmployeeManagementAPI.Repositories
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly IConfiguration _configuration;
        public EmployeeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            using var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConn"));

            return connection.Query<Employee>(
                "GetEmployees",
                commandType: System.Data.CommandType.StoredProcedure
            );
        }
        public Employee GetEmployeeById(int id)
        {
            using var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection"));

            return connection.QueryFirstOrDefault<Employee>(
                "GetEmployeeById",
                new { EmpID = id },
                commandType: CommandType.StoredProcedure);
        }
        public int AddEmployee(Employee employee)
        {
            using var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection"));

            return connection.Execute(
                "AddEmployee",
                employee,
                commandType: CommandType.StoredProcedure);
        }
        //public int UpdateEmployee(Employee employee)
        //{
        //    using var connection = new SqlConnection(
        //        _configuration.GetConnectionString("DefaultConnection"));

        //    string query = @"
        //UPDATE Employees
        //SET
        //    FullName = @FullName,
        //    Gender = @Gender,
        //    Phone = @Phone,
        //    Email = @Email,
        //    Salary = @Salary
        //WHERE EmpID = @EmpID";

        //    return connection.Execute(query, employee);
        //}
        public int UpdateEmployee(Employee employee)
        {
            using var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection"));

            return connection.Execute(
                "UpdateEmployee",
                employee,
                commandType: CommandType.StoredProcedure);
        }
        //public int InactivateEmployee(int id)
        //{
        //    using var connection = new SqlConnection(
        //        _configuration.GetConnectionString("DefaultConnection"));

        //    string query = @"
        //UPDATE Employees
        //SET IsActive = 0
        //WHERE EmpID = @EmpID";

        //    return connection.Execute(
        //        query,
        //        new { EmpID = id });
        //}
        public int InactivateEmployee(int id)
        {
            using var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection"));

            return connection.Execute(
                "InactivateEmployee",
                new { EmpID = id },
                commandType: CommandType.StoredProcedure);
        }

    }
}