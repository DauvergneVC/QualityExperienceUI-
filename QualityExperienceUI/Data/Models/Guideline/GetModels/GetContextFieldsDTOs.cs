namespace QualityExperienceUI.Data.Models.Guideline.GetModels
{
    public class GetContextFieldsTypesDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Label { get; set; }
        public string? Size { get; set; }
        public int MaxLength { get; set; }
        public int Order { get; set; }
        public bool Required { get; set; }
        public bool Visible { get; set; }
        public int TemplateId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class GetContextFielValuesdDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ContextFieldTypeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
