using DocumentFormat.OpenXml.Drawing.Diagrams;
using Job_Application_Tracker_API.Entities;
using Job_Application_Tracker_API.Entities.Enums;

namespace Job_Application_Tracker_API.DTOs.Jobs
{
    public class CreateJobApplicationDto
    {
        public string? JobTitle { get; set; }
        public string? JobDescription { get; set; }
        public decimal? OfferedSalary { get; set; }
        public ApplicationStatus Status { get; set; }
        public DateTime AppliedDate { get; set; }
        public DateTime? InterviewDateTime { get; set; }

        public JobApplication TojobApplication()
       {
            return new JobApplication()
            {
               JobApplicationId = Guid.NewGuid(),
                JobTitle = JobTitle,
                JobDescription = JobDescription,
                OfferedSalary = OfferedSalary,
                AppliedDate = AppliedDate,
                InterviewDateTime = InterviewDateTime,
                Status = Entities.Enums.ApplicationStatus.Applied
            };
       }
    }
}
