using DocumentFormat.OpenXml.ExtendedProperties;

namespace Job_Application_Tracker_API.Entities.Companies;

public class UpdateCompanyDto
{
    public string? CompanyName { get; set; }
    public string? Website { get; set; }
    public string? Location { get; set; }

    /// <summary>
    /// Convert the current object of UpdateCompanyDto into a new object of Company Type
    /// </summary>
    /// <returns>A new instance of Company with the updated values.</returns>
    public Company ToCompany()
    {
        return new Company
        {
            CompanyName = CompanyName,
            Website = Website,
            Location = Location
        };
    }
}
