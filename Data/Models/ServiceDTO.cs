namespace QualityExperienceUI.Data.Models
{
    public class ServiceListDTO
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int? templateID { get; set; }
        public object? templateName { get; set; }
        public int? order { get; set; }
        public int? authorID { get; set; }
        public int? serviceCategoryID { get; set; }
        public object? serviceCategoryName { get; set; }
        public string? serviceType { get; set; }
        public string? operationType { get; set; }
        public string? status { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
    }

    public class CategoriesListDTO
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int? order { get; set; }
        public int? authorID { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
    }
}