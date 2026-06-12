namespace Job_Application_Tracker_API.Entities
{
    /// <summary>
    /// Domain Model for Company
    /// </summary>
    public class Company
    {
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Website { get; set; }
        public string Location { get; set; }

    }
}
