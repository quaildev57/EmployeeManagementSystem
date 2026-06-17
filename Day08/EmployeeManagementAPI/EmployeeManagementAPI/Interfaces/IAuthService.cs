using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Interfaces
{
    public interface IAuthService
    {
        User? Login(LoginRequest request);
    }
}
