namespace QualityExperienceUI.Data.Models.Guideline.GetModels
{
    public class GetQuestionsDTO
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public int? GroupId { get; set; }
        public int? SubGroupId { get; set; }
        public int AuthorId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Order { get; set; }
        public int CriticalQuestionValue { get; set; }
        public string? Type { get; set; }
        public string? Status { get; set; }
        public string? Critical { get; set; }
        public string? CalculationType { get; set; }
        public decimal GlobalWeight { get; set; }
        public decimal IndicatorWeight { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public QuestionEvaluationControlResponse? QuestionEvaluationControl { get; set; }
        public List<QuestionItemResponse>? QuestionItems { get; set; }


        // Associated sub classes
        public class QuestionEvaluationControlResponse
        {
            public int Id { get; set; }
            public string? EvaluationControl { get; set; }
            public string? Description { get; set; }
            public List<int>? Values { get; set; }
        }

        public class QuestionItemResponse
        {
            public int Id { get; set; }
            public string? ControlType { get; set; }
            public string? Size { get; set; }
            public string? Label { get; set; }
        }
    }

    public class GetQuestionsByTemplateIdDTO
    {
        // Obtiene el grupo, subgrupos preguntas del grupo y items
        // group
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int TemplateId { get; set; }
        public int Order { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<QuestionResponse>? Questions { get; set; }
        public List<SubGroupResponse>? SubGroups { get; set; }


        // Associated sub classes
        public class QuestionResponse
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Description { get; set; }
            public int Order { get; set; }
            public int CriticalQuestionValue { get; set; }
            public string? Type { get; set; }
            public string? Status { get; set; }
            public string? Critical { get; set; }
            public string? CalculationType { get; set; }
            public decimal GlobalWeight { get; set; }
            public decimal IndicatorWeight { get; set; }
            public int? IndicatorID { get; set; }
            public QuestionEvaluationControlResponse? QuestionEvaluationControl { get; set; }
            public List<QuestionItemResponse>? QuestionItems { get; set; }
        }
        public class QuestionEvaluationControlResponse
        {
            public int Id { get; set; }
            public string? EvaluationControl { get; set; }
            public string? Description { get; set; }
            public List<int>? Values { get; set; }
        }
        public class QuestionItemResponse
        {
            public int Id { get; set; }
            public string? ControlType { get; set; }
            public string? Size { get; set; }
            public string? Label { get; set; }
        }
        public class SubGroupResponse
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Description { get; set; }
            public int Order { get; set; }
            public int GroupId { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
            public List<QuestionResponse>? Questions { get; set; }
        }
    }

    public class GetQuestionsEvaluationControlsDTO
    {
        public int Id { get; set; }
        public string? EvaluationControl { get; set; }
        public string? Description { get; set; }
        public List<int>? Values { get; set; }
    }

    public class GetQuestionItemListValuesDTO
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public int Order { get; set; }
        public int QuestionItemId { get; set; }
    }
}
