using Job_Application_Tracker_API.Entities.Enums;

namespace Job_Application_Tracker_API.Entities
{
    /// <summary>
    /// Domain Model for a job application
    /// </summary>
    public class JobApplication
    {
        public Guid JobApplicationId { get; set; }
        public Guid UserId { get; set; }
        public Guid CompanyId { get; set; }
        public string? JobTitle { get; set; }
        public string? JobDescription { get; set; }
        public decimal? OfferedSalary { get; set; }
        public ApplicationStatus Status { get; set; }
        public DateTime AppliedDate { get; set; }
        public DateTime? InterviewDateTime{ get; set; }
    }
}
