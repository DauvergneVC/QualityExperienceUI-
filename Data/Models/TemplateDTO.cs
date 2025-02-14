using System.ComponentModel.DataAnnotations;

namespace QualityExperienceUI.Data.Models
{
    public class TemplateListDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public object? AuthorID { get; set; }
        public int? ClientID { get; set; }
        public string? Status { get; set; }
        public bool? Archived { get; set; }
        public string? CalculationType { get; set; }
        public string? AllowAttachment { get; set; }
        public string? FeedbackType { get; set; }
        public string? TemplateType { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }


    }
    public class TemplateListByIDDto
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public object? AuthorID { get; set; }
        public string? Status { get; set; }
        public string? CalculationType { get; set; }
        public string? AllowAttachment { get; set; }
        public string? FeedbackType { get; set; }
        public string? TemplateType { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }


    }

    public class TemplateCreateDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? AuthorID { get; set; }
        public int ClientID { get; set; }
        public string? CalculationType { get; set; }
        public string? AllowAttachment { get; set; }
        public string? FeedbackType { get; set; }
        public string? TemplateType { get; set; }
    }

    public class TemplateUpdateDTO
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public int status { get; set; }
        public int calculationType { get; set; }
        public int allowAttachment { get; set; }
        public int feedbackType { get; set; }
        public int templateType { get; set; }
    }

    // Option in templates
    public class NameValuePair
    {
        public string Name { get; set; } = string.Empty;
        public int Value { get; set; }
    }
    public class TemplateOptionsDto
    {
        public List<NameValuePair> TemplateStatus { get; set; } = new();
        public List<NameValuePair> CalculationType { get; set; } = new();
        public List<NameValuePair> AllowAttachment { get; set; } = new();
        public List<NameValuePair> FeedbackType { get; set; } = new();
        public List<NameValuePair> TemplateType { get; set; } = new();
    }
}
