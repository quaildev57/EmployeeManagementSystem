using EmployeeManagementAPI.Interfaces;
using EmployeeManagementAPI.Models;
namespace EmployeeManagementAPI.Services
{
    public class AuthService : IAuthService
    {
        private readonly IEmployeeRepository _repository;
        public AuthService(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public User? Login(LoginRequest request)
        {
            return _repository.ValidateUser(request.Username, request.Password);
        }
    }
}
