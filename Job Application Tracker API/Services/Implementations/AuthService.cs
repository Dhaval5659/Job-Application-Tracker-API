using Job_Application_Tracker_API.Data;
using Job_Application_Tracker_API.DTOs.Auth;
using Job_Application_Tracker_API.Entities;
using Job_Application_Tracker_API.Helpers;
using Job_Application_Tracker_API.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Job_Application_Tracker_API.Services.Implementations
{
    public class AuthService : IAuthService
    {
        // private field
        private readonly ApplicationDbContext _db;
        private readonly JwtHelper _jwtHelper;

        // constructor
        public AuthService(ApplicationDbContext db, JwtHelper jwtHelper)
        {
            _db = db;
            _jwtHelper = jwtHelper;
        }

        public async Task<AuthResponse> Register(RegisterRequest request)
        {
            bool emailExists = await _db.ApplicationUsers.AnyAsync(u => u.Email == request.Email);

            if (emailExists)
            {
                throw new Exception("Email already registered");
            }

            ApplicationUser user = new()
            {
                UserId = Guid.NewGuid(),
                UserName = request.UserName,
                Email = request.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(
                    request.Password),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _db.ApplicationUsers.Add(user);
            await _db.SaveChangesAsync();

            string token = _jwtHelper.GenerateToken(user);

            return new AuthResponse
            {
                UserId = user.UserId,
                UserName = request.UserName,
                Email = request.Email,
                Token = token

            };

        }

        public async Task<AuthResponse> Login(LoginRequest request)
        {
            ApplicationUser? user = await _db.ApplicationUsers
                .FirstOrDefaultAsync(u =>
                u.Email == request.Email);

            if (user == null)
            {
                throw new Exception("Invalid email or password");
            }

            bool isValidPassword = BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash);

            string token = _jwtHelper.GenerateToken(user);

            return new AuthResponse
            {
                UserId = user.UserId,
                UserName = user.UserName,
                Email = user.Email,
                Token = token
            };
        }

        
    }
}
