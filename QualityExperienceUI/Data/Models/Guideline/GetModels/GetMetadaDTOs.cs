using QualityExperienceUI.Data.Models.Guideline;

namespace QualityExperienceUI.Data.Models.Guideline.GetModels
{
    public class GetGroupMetadataDTO
    {
        public List<MetadataNameValue> GroupType { get; set; } = new();
    }

    public class GetTemplateMetadataDTO
    {
        public List<MetadataNameValue> Status { get; set; } = new();
        
        public List<MetadataNameValue> CalculationType { get; set; } = new();
        public List<MetadataNameValue> AllowAttachment { get; set; } = new();
        public List<MetadataNameValue> FeedbackType { get; set; } = new();
        public List<MetadataNameValue> TemplateType { get; set; } = new();
    }

    public class GetQuestionMetadataDTO
    {
        public List<string>? QuestionType { get; set; }
        public List<string>? QuestionStatus { get; set; }
        public List<string>? CriticalQuestion { get; set; }
        public List<string>? CalculationQuestionType { get; set; }
        public List<string>? EvaluationControl { get; set; }
    }
}
