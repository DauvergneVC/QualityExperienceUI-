namespace QualityExperienceUI.Data.Models.Guideline.PutModels
{
    public class PutTemplatesDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? ClientId { get; set; }
        public string? Status { get; set; }
        public string? CalculationType { get; set; }
        public string? AllowAttachment { get; set; }
        public string? FeedbackType { get; set; }
        public string? TemplateType { get; set; }
    }

    public class PutServicesAssociatedByTemplateIdDTO
    {
        // This model is for remobe a item of the list of services ids, the services ids in model will be removed
        public int TemplateId { get; set; }
        public List<int>? ServiceIds { get; set; }
    }
}
