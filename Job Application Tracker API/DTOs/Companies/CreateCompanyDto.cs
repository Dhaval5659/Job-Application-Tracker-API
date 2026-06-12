using Job_Application_Tracker_API.Entities;

namespace Job_Application_Tracker_API.DTOs.Companies
{
    public class CreateCompanyDto
    {
        public string? CompanyName { get; set; }
        public string? Website { get; set; }
        public string? Location { get; set; }

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
