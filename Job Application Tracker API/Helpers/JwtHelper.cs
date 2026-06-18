using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Job_Application_Tracker_API.Entities;
using Microsoft.IdentityModel.Tokens;

namespace Job_Application_Tracker_API.Helpers
{
    public class JwtHelper
    {
        // This class is responsible for generating JWT tokens for authenticated users. It uses the configuration settings to retrieve the secret key and other token parameters.
        private readonly IConfiguration _configuration;

        // Constructor 
        public JwtHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Generate Token
        public string GenerateToken(ApplicationUser user)
        {
            // Create Claims
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Name, user.UserName ?? ""),
                new Claim(ClaimTypes.Email, user.Email ?? ""),
            };

            // Creating Security Key
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(
                    _configuration["Jwt:Key"]!
                    ));

            // Creating Signing Credentials
            var credentials =
                new SigningCredentials(
                    key,
                    SecurityAlgorithms.HmacSha256);

            // Creating JWT Token
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
