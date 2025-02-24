namespace QualityExperienceUI.Data.Models.PutModels
{
    public class PutQuestionDTO
    {
        public int? groupId { get; set; }
        public int? subGroupId { get; set; }
        public int? indicatorId { get; set; }
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
        public int? questionEvaluationControlId { get; set; }
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
