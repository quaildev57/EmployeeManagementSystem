using EmployeeManagementAPI.Interfaces;
using EmployeeManagementAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IJwtService _jwtService;

        public AuthController(IAuthService authService, IJwtService jwtService)
        {
            _authService = authService;
            _jwtService = jwtService;
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
            var token = _jwtService.GenerateToken(user);
            return Ok(
                new
                {
                    Message = "Login Successful",
                    //UserID = user.UserID,
                    //Username = user.Username,
                    //RoleID = user.RoleI                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           D
                    Token = token
                }

                );
        }
            [Authorize]
            [HttpGet("me")]
            public IActionResult GetCurrentUser()
            {
                var username = User.FindFirst(ClaimTypes.Name)?.Value;

                var userId = User.FindFirst("UserID")?.Value;

                var role = User.FindFirst(ClaimTypes.Role)?.Value;
            var department = User.FindFirst("Department")?.Value;

                return Ok(new
                {
                    UserID = userId,
                    Username = username,
                    Role = role,
                    Department = department
                });
            }
        //adding this temporarily to see what ASP.NET extracted from JWT
        [Authorize]
        [HttpGet("claims")]
        public IActionResult GetClaims()
        {
            return Ok(
                User.Claims.Select(c => new
                {
                    c.Type,
                    c.Value
                }));
        }

    }
}