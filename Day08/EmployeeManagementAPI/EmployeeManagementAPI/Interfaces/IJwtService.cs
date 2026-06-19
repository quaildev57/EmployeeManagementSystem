using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}
