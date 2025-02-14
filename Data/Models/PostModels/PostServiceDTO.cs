namespace QualityExperienceUI.Data.Models.PostModels
{
    public class PostServicesDTO
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public int order { get; set; }
        public int authorId { get; set; }
        public int serviceCategoryId { get; set; }
        public string? serviceType { get; set; }
        public string? operationType { get; set; }
        public string? status { get; set; }
    }

    public class PostServicesCategoriesDTO
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public int order { get; set; }
        public int authorId { get; set; }
    }
}
