namespace Job_Application_Tracker_API.DTOs.Companies
{
    /// <summary>
    /// DTO class that is used as return type for most of the Company methods
    /// </summary>
    public class CompanyResponseDto
    {
        public Guid CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? Website { get; set; }
        public string? Location { get; set; }

        public override bool Equals(object? obj)
        {
            if(obj == null)
            {
                return false;
            }

            if(obj.GetType() != typeof(CompanyResponseDto))
            {
                return false;
            }

            CompanyResponseDto company_compare = (CompanyResponseDto)obj;
            return CompanyId == company_compare.CompanyId &&
                   CompanyName == company_compare.CompanyName &&
                   Website == company_compare.Website &&
                   Location == company_compare.Location;
        }
    }

    public static class CompanyResponseDtoExtensions
    {
        public static CompanyResponseDto ToCompanyResponseDto(this Entities.Company company)
        {
            return new CompanyResponseDto()
            {
                CompanyId = company.CompanyId,
                CompanyName = company.CompanyName,
                Website = company.Website,
                Location = company.Location
            };
        }
    }  
}
