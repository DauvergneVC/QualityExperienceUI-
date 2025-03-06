namespace QualityExperienceUI.Data.Models.Guideline.GetModels
{
    public class GetTemplatesDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? AuthorId { get; set; }
        public int ClientId { get; set; }
        public string? Status { get; set; } // Associated with metadata
        public bool Archived { get; set; }
        public string? CalculationType { get; set; } // Associated with metadata
        public string? AllowAttachment { get; set; } // Associated with metadata
        public string? FeedbackType { get; set; } // Associated with metadata
        public string? TemplateType { get; set; } // Associated with metadata
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
    public class GetTemplateByIdDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? AuthorId { get; set; }
        public string? Status { get; set; } // Associated with metadata
        public string? CalculationType { get; set; } // Associated with metadata
        public string? AllowAttachment { get; set; } // Associated with metadata
        public string? FeedbackType { get; set; } // Associated with metadata
        public string? TemplateType { get; set; } // Associated with metadata
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
    public class GetTemplatesByFiltersDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? AuthorId { get; set; }
        public int ClientId { get; set; }
        public string? ClientName { get; set; }
        public string? Status { get; set; } // Associated with metadata
        public string? CalculationType { get; set; } // Associated with metadata
        public string? AllowAttachment { get; set; } // Associated with metadata
        public string? FeedbackType { get; set; } // Associated with metadata
        public string? TemplateType { get; set; } // Associated with metadata
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }

    public class GetServicesAssociatedByTemplateIdDTO
    {
        public int TemplateId { get; set; }
        public List<int>? ServiceIds { get; set; }
    }
}
