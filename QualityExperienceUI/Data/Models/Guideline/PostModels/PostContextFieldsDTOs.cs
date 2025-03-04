namespace QualityExperienceUI.Data.Models.Guideline.PostModels
{
    public class PostContextFieldTypesdDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Label { get; set; }
        public string? Size { get; set; }
        public int MaxLength { get; set; }
        public int Order { get; set; }
        public bool Required { get; set; }
        public bool Visible { get; set; }
        public int TemplateId { get; set; }
    }

    public class PostContextFieldValuesDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int ContextFieldTypeId { get; set; }
    }
}
