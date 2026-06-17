using EmployeeManagementAPI.Interfaces;
using EmployeeManagementAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var user = _authService.Login(request);

            if (user == null)
            {
                return Unauthorized(
                    new
                    {
                        Message = "Invalid Username or Password"
                    });
            }

            return Ok(
                new
                {
                    Message = "Login Successful",
                    UserID = user.UserID,
                    Username = user.Username,
                    RoleID = user.RoleID
                });
        }
    }
}