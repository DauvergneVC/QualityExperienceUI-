namespace QualityExperienceUI.Data.Models.GetModels
{
    public class GetServiceDTO
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int order { get; set; }
        public int authorId { get; set; }
        public int serviceCategoryId { get; set; }
        public string? serviceType { get; set; }
        public string? operationType { get; set; }
        public string? status { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
    public class GetServiceByCategoryDTO
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int templateId { get; set; }
        public string? templateName { get; set; }
        public int order { get; set; }
        public int authorId { get; set; }
        public int serviceCategoryId { get; set; }
        public string? serviceCategoryName { get; set; }
        public string? serviceType { get; set; }
        public string? operationType { get; set; }
        public string? status { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
    public class GetServiceCategoriesDTO
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int order { get; set; }
        public int authorID { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
    }
}
