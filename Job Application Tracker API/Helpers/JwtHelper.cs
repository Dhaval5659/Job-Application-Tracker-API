using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Job_Application_Tracker_API.Entities;
using Microsoft.IdentityModel.Tokens;

namespace Job_Application_Tracker_API.Helpers
{
    public class JwtHelper
    {
        private readonly IConfiguration _configuration;

        public JwtHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateToken(ApplicationUser user)
        {
            // Create claims
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserName.ToString()),
                new Claim(ClaimTypes.Name, user.UserName ?? ""),
                new Claim(ClaimTypes.Email, user.Email ?? "")
            };

            // Creating symmetric Security key
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(
                    _configuration["Jwt:Key"]!
                    ));

            // Creating Signing Credentials
            var credentials = new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256
                );

            // Creating Jwt Token
            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddDays(7),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler()
                .WriteToken(token);

        }
       
       
    }
}
