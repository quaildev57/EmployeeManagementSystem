using EmployeeManagementAPI.Interfaces;
using EmployeeManagementAPI.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EmployeeManagementAPI.Services
{
    public class JwtService : IJwtService
    {
        private readonly IConfiguration _configuration;

        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateToken(User user)
        {
            //var claims = new[]
            //{
            //    new Claim(ClaimTypes.Name, user.Username),
            //    new Claim("UserID", user.UserID.ToString()),
            //    new Claim("RoleID", user.RoleID.ToString())
            //};

            string role = user.RoleID switch
            {
                1 => "Admin",
                2 => "HR",
                3 => "Employee",
                _ => "Employee"
            };

            var claims = new[]
            {
    new Claim(ClaimTypes.Name, user.Username),
    new Claim("UserID", user.UserID.ToString()),
    new Claim(ClaimTypes.Role, role),
    new Claim("Department", "IT")
};

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(
                    _configuration["Jwt:Key"]!));

            var creds = new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler()
                .WriteToken(token);
        }
    }
}