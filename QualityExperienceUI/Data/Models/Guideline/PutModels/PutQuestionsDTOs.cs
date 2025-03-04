namespace QualityExperienceUI.Data.Models.Guideline.PutModels
{
    public class PutQuestionsDTO
    {
        public int? GroupId { get; set; }
        public int? SubGroupId { get; set; }
        public int? IndicatorId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Order { get; set; }
        public int? CriticalQuestionValue { get; set; }
        public string? Type { get; set; }
        public string? Status { get; set; }
        public string? Critical { get; set; }
        public string? CalculationType { get; set; }
        public decimal? GlobalWeight { get; set; }
        public decimal? IndicatorWeight { get; set; }
        public int? QuestionEvaluationControlId { get; set; }
    }

    public class PutQuestionItemDTO
    {
        public string? ControlType { get; set; }
        public string? Size { get; set; }
        public string? Label { get; set; }
    }

    /*
     public enum ControlType
    {
        DropdownSingle = 1,
        DropdownMultiple = 2,
        TextArea = 3,
        Text = 4, 
        Number = 5,
        Color = 6,
        Email = 7,
        Date = 8,
        Time = 9
     }

    public enum Size
    {
        Small = 1,
        Medium = 2,
        Large = 3
    }

    public enum Status
    {
        Active = 1,
        Inactive = 2,
        Deleted = 3
    }

    public enum CriticalQuestion
    {
        Yes = 1,
        No = 2
    }

    public enum CalculationQuestionType
    {
        Binary = 1,
        Discount= 2
    }
     */
}
