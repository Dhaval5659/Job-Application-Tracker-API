using Job_Application_Tracker_API.Entities;
using Job_Application_Tracker_API.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace Job_Application_Tracker_API.DTOs.Jobs
{
    public class UpdateJobApplicationDto
    {
        [Required]
        public string? JobTitle { get; set; }
        public string? JobDescription { get; set; }
        public decimal? OfferedSalary { get; set; }
        public ApplicationStatus Status { get; set; }
        public DateTime AppliedDate { get; set; }
        public DateTime? InterviewDateTime { get; set; }

        /// <summary>
        /// Convert the current object of UpdateJobApplicationDto into a new object of JobApplication Type
        /// </summary>
        /// <returns>A new instance of JobApplication with the updated values.</returns>
        public JobApplication ToJobApplication()
        {
            return new JobApplication
            {
                JobTitle = JobTitle,
                JobDescription = JobDescription,
                OfferedSalary = OfferedSalary,
                Status = Status,
                AppliedDate = AppliedDate,
                InterviewDateTime = InterviewDateTime
            };
        }
    }
}