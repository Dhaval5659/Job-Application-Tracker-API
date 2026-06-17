using Job_Application_Tracker_API.Entities;

namespace Job_Application_Tracker_API.DTOs.Companies
{
    /// <summary>
    /// Acts as a DTO for inserting a new Company
    /// </summary>
    public class CreateCompanyDto
    {
        public string? CompanyName { get; set; }
        public string? Website { get; set; }
        public string? Location { get; set; }

        /// <summary>
        /// Convert the current object of CreateCompanyDto into a new object of Company Type
        /// </summary>
        /// <returns></returns>

        public Company ToCompany()
        {
            return new Company()
            {
                CompanyName = CompanyName,
                Website = Website,
                Location = Location
            };
        }
    }
}
