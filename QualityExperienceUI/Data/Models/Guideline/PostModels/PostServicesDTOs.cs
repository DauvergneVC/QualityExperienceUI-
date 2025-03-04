namespace QualityExperienceUI.Data.Models.Guideline.PostModels
{
    public class PostServiceDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Order { get; set; }
        public int AuthorId { get; set; }
        public int ServiceCategoryId { get; set; }
        public string? ServiceType { get; set; } // Use example of down, USE NUMBER
        public string? OperationType { get; set; } // Use example of down, USE NUMBER

        /*
         BackEnd Service command
        public enum ServiceType
        {
            CustomerService = 1,
            Sales = 2,
            TechnicalSupport = 3,
            Collections = 4,
            CustomerRetention = 5,
            CustomerExperience = 6,
            CustomerLoyalty = 7,
            CustomerAcquisition = 8,
            Complaints = 9,
            Apointments = 10,
        }
        public enum OperationType
        {
            Inbound = 1,
            Outbound = 2,
            Blended = 3,
            Chat = 4,
            Email = 5,
            SocialMedia = 6
        }
        */
    }

    public class PostServiceCategoryDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Order { get; set; }
        public int AuthorId { get; set; }
    }
}
