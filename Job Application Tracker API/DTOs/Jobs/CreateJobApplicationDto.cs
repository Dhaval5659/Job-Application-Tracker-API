using Job_Application_Tracker_API.Entities;

namespace Job_Application_Tracker_API.DTOs.Jobs
{
    public class CreateJobApplicationDto
    {
       public string? Position { get; set; }
       public string? Description { get; set; }
       public decimal? OfferedSalary { get; set; }
       public DateTime AppliedDate { get; set; }
       public DateTime? InterviewDateTime { get; set; }

       public JobApplication TojobApplication()
       {
            return new JobApplication()
            {
               JobApplicationId = Guid.NewGuid(),
                JobTitle = Position,
                JobDescription = Description,
                OfferedSalary = OfferedSalary,
                AppliedDate = AppliedDate,
                InterviewDateTime = InterviewDateTime,
                Status = Entities.Enums.ApplicationStatus.Applied
            };
       }
    }
}
