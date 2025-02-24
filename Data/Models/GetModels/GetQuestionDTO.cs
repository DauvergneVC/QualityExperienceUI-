namespace QualityExperienceUI.Data.Models.GetModels
{
    public class GetQuestionsDTO
    {
        public int id { get; set; }
        public int templateId { get; set; }
        public int? groupId { get; set; }
        public int? subGroupId { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int? order { get; set; }
        public int? criticalQuestionValue { get; set; }
        public string? type { get; set; }
        public string? status { get; set; }
        public string? critical { get; set; }
        public string? calculationType { get; set; }
        public decimal? globalWeight { get; set; }
        public decimal? indicatorWeight { get; set; }
        public int? indicatorID { get; set; }
        public QuestionEvaluationControl? questionEvaluationControl { get; set; }
        public List<QuestionItems>? questionItems { get; set; }
    }


    public class GetQuestionsByTemplateIdDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int TemplateId { get; set; }
        public int Order { get; set; }
        public int AuthorId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<QuestionResponse>? Questions { get; set; }
        public List<SubGroupResponse>? SubGroups { get; set; }

    }
    #region Related with GetQuestionsByTemplateIdDTO
    public class QuestionResponse
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int? order { get; set; }
        public int? criticalQuestionValue { get; set; }
        public string? type { get; set; }
        public string? status { get; set; }
        public string? critical { get; set; }
        public string? calculationType { get; set; }
        public decimal? globalWeight { get; set; }
        public decimal? indicatorWeight { get; set; }
        public int? indicatorID { get; set; }
        public QuestionEvaluationControl? questionEvaluationControl { get; set; }
        public List<QuestionItems>? questionItems { get; set; }
    }
    public class QuestionEvaluationControl
    {
        public int id { get; set; }
        public string? evaluationControl { get; set; }
        public string? description { get; set; }
        public List<int>? values { get; set; }
    }

    public class QuestionItems
    {
        public int id { get; set; }
        public string? controlType { get; set; }
        public string? controlSize { get; set; }
        public string? label { get; set; }
    }
    public class SubGroupResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Order { get; set; }
        public int? GroupId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public List<QuestionResponse>? Questions { get; set; }
    }

    #endregion
}
