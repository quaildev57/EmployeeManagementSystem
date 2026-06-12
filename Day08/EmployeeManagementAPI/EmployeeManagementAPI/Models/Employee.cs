namespace EmployeeManagementAPI.Models
{
    public class Employee
    {
        public int EmpID { get; set; }

        public string FullName { get; set; } = "";

        public string Gender { get; set; } = "";

        public DateTime DOB { get; set; }

        public string Address { get; set; } = "";

        public string Phone { get; set; } = "";

        public string Email { get; set; } = "";

        public int DeptID { get; set; }

        public int UserID { get; set; }

        public DateTime JoinDate { get; set; }

        public decimal Salary { get; set; }

        public bool IsActive { get; set; }
    }
}