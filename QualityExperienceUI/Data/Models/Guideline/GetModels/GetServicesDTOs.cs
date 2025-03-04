namespace QualityExperienceUI.Data.Models.Guideline.GetModels
{
    public class GetServicesDTO
    {
        // Same for get all Services and get services by ID
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Order { get; set; }
        public int AuthorId { get; set; }
        public int ServiceCategoryId { get; set; }
        public string? ServiceType { get; set; }
        public string? OperationType { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class GetServicesByCategoryDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int TemplateId { get; set; }
        public string? TemplateName { get; set; }
        public int Order { get; set; }
        public int AuthorId { get; set; }
        public int ServiceCategoryId { get; set; }
        public string? ServiceCategoryName { get; set; }
        public string? ServiceType { get; set; }
        public string? OperationType { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class GetServiceCategoriesDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Order { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
