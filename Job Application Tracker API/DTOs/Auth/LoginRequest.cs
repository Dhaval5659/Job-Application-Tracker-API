using System.ComponentModel.DataAnnotations;

namespace Job_Application_Tracker_API.DTOs.Auth
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
