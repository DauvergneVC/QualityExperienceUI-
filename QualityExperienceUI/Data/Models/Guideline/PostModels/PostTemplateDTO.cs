namespace QualityExperienceUI.Data.Models.Guideline.PostModels
{
    public class PostTemplateDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int AuthorId { get; set; } = 0;
        public int ClientId { get; set; } = 0;
        public string? CalculationType { get; set; } // Associated with metadata
        public string? AllowAttachment { get; set; } // Associated with metadata
        public string? FeedbackType { get; set; } // Associated with metadata
        public string? TemplateType { get; set; } // Associated with metadata
    }

    public class PostServicesAssociatedByTemplateIdDTO
    {
        // this model is not for create, this associated services ids to a template, the list will be included services to ssociate
        public int TemplateId { get; set; }
        public List<int>? ServiceIds { get; set; }
    }
}
