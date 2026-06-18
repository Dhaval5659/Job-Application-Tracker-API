using System.ComponentModel.DataAnnotations;

namespace Job_Application_Tracker_API.DTOs.Auth
{
    public class RegisterRequest
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [MinLength(6)]
        public string? Password { get; set; }

    }
}
