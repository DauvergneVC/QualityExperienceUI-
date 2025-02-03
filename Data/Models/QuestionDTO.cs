namespace QualityExperienceUI.Data.Models
{
    public class QuestionListDTO
    {

    }


    // Metadata
    public class QuestionStructure
    {
        public int id { get; set; }
        public int templateID { get; set; }
        public int? groupID { get; set; }
        public int? subGroupID { get; set; }
        public int authorID { get; set; }
        public decimal? weightIndicatorID { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }
        public int order { get; set; }
        public int criticalQuestionValue { get; set; }
        public int? type { get; set; }
        public int? status { get; set; }
        public int? critical { get; set; }
        public int? calculationType { get; set; }
        public decimal? globalWeight { get; set; }
        public decimal? indicatorWeight { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

    public class QuestionEvaluationControlStructure
    {
        public int id { get; set; }
        public int? evaluationControl { get; set; }
        public string? description { get; set; }
        public List<int>? values { get; set; }
    }

    public class OptionAutoValue
    {
        public string Name { get; set; } = string.Empty;

    }
    public class QuestionsMetadata
    {
        public QuestionStructure questionStructure { get; set; } = new();
        public QuestionEvaluationControlStructure questionEvaluationControlStructure { get; set; } = new();
        public List<OptionAutoValue> questionType { get; set; } = new();
        public List<OptionAutoValue> questionStatus { get; set; } = new();
        public List<OptionAutoValue> criticalQuestion { get; set; } = new();
        public List<OptionAutoValue> calculationQuestionType { get; set; } = new();
        public List<OptionAutoValue> evaluationControl { get; set; } = new();

    }
}
