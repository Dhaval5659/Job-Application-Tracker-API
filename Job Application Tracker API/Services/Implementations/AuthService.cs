using Job_Application_Tracker_API.Data;
using Job_Application_Tracker_API.DTOs.Auth;
using Job_Application_Tracker_API.Services.Contracts;

namespace Job_Application_Tracker_API.Services.Implementations
{
    public class AuthService : IAuthService
    {
        // private field
        private readonly ApplicationDbContext _db;

        // constructor
        public AuthService(ApplicationDbContext authDbContext)
        {
            _db = authDbContext;
        }

        public async Task<AuthResponse> Login(LoginRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<AuthResponse> Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
