
namespace Job_Application_Tracker_API.Entities
{
    /// <summary>
    /// Domain Model for ApplicationUser
    /// </summary>
    public class ApplicationUser
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
