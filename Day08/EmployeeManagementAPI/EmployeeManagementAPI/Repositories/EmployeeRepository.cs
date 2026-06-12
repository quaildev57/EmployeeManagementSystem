using Dapper;
using Microsoft.Data.SqlClient;
using EmployeeManagementAPI.Models; 

namespace EmployeeManagementAPI.Repositories
{
    public class EmployeeRepository
    {
        private readonly IConfiguration _configuration;
        public EmployeeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IEnumerable<Employee> GetEmployees(){
            using var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection"));
            string query = "SELECT * FROM Employees";
            return connection.Query<Employee>(query);
        }
        public Employee GetEmployeeById(int id)
        {
            using var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection"));

            string query =
                "SELECT * FROM Employees WHERE EmpID = @EmpID";

            return connection.QueryFirstOrDefault<Employee>(
                query,
                new { EmpID = id });
        }
        public int AddEmployee(Employee employee)
        {
            using var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection"));

            string query = @"
        INSERT INTO Employees
        (
            FullName,
            Gender,
            DOB,
            Address,
            Phone,
            Email,
            DeptID,
            UserID,
            JoinDate,
            Salary,
            IsActive
        )
        VALUES
        (
            @FullName,
            @Gender,
            @DOB,
            @Address,
            @Phone,
            @Email,
            @DeptID,
            @UserID,
            @JoinDate,
            @Salary,
            @IsActive
        )";

            return connection.Execute(query, employee);
        }
        public int UpdateEmployee(Employee employee)
        {
            using var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection"));

            string query = @"
        UPDATE Employees
        SET
            FullName = @FullName,
            Gender = @Gender,
            Phone = @Phone,
            Email = @Email,
            Salary = @Salary
        WHERE EmpID = @EmpID";

            return connection.Execute(query, employee);
        }
        public int InactivateEmployee(int id)
        {
            using var connection = new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection"));

            string query = @"
        UPDATE Employees
        SET IsActive = 0
        WHERE EmpID = @EmpID";

            return connection.Execute(
                query,
                new { EmpID = id });
        }

    }
}