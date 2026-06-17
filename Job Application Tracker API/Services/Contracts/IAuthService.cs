using Job_Application_Tracker_API.DTOs.Auth;

namespace Job_Application_Tracker_API.Services.Contracts
{
    /// <summary>
    /// Represents business logic for Register and add new user and Login existing user.
    /// </summary>
    public interface IAuthService
    {
        /// <summary>
        /// Registera a new user and returns an authentication response containing user details and a token.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<AuthResponse> Register(RegisterRequest? request);

        /// <summary>
        /// Authenticates a user and returns an authentication response containing user details and a token.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<AuthResponse> Login(LoginRequest? request);
    }
}
