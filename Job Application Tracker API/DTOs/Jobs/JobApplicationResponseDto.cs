namespace Job_Application_Tracker_API.DTOs.Jobs
{
    /// <summary>
    /// DTO class that is used as return type for most of the Job Application methods 
    /// </summary>
    public class JobApplicationResponseDto
    {
        public Guid JobApplicationId { get; set; }
        public string? JobTitle { get; set; }
        public string? JobDescription { get; set; }
        public decimal? OfferedSalary { get; set; }
        public DateTime AppliedDate { get; set; }
        public DateTime? InterviewDateTime { get; set; }
        public string? Status { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if(obj.GetType() != typeof(JobApplicationResponseDto))
            {
                return false;
            }
            JobApplicationResponseDto  job_compare = (JobApplicationResponseDto)obj;

            return JobApplicationId == job_compare.JobApplicationId &&
                JobTitle == job_compare.JobTitle &&
                JobDescription == job_compare.JobDescription &&
                OfferedSalary == job_compare.OfferedSalary &&
                AppliedDate == job_compare.AppliedDate &&
                InterviewDateTime == job_compare.InterviewDateTime &&
                Status == job_compare.Status;
        }

        //returns an unique key for the current object
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Job Application Id: {JobApplicationId}, Job Title: {JobTitle}, Job Description: {JobDescription}, Offered Salary: {OfferedSalary}, Applied Date: {AppliedDate}, Interview DateTime: {InterviewDateTime}, Status: {Status}";
        }

    }

    public static class JobApplicationResponseDtoExtensions
    {
        public static JobApplicationResponseDto ToJobApplicationResponseDto(this Entities.JobApplication jobApplication)
        {
            return new JobApplicationResponseDto()
            {
                JobApplicationId = jobApplication.JobApplicationId,
                JobTitle = jobApplication.JobTitle,
                JobDescription = jobApplication.JobDescription,
                OfferedSalary = jobApplication.OfferedSalary,
                AppliedDate = jobApplication.AppliedDate,
                InterviewDateTime = jobApplication.InterviewDateTime,
                Status = jobApplication.Status.ToString()
            };
        }
    }
}
