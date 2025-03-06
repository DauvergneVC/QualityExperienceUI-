using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace QualityExperienceUI.Data.Models.Guideline.PostModels
{
    public class PostQuestionDTO
    {
        public int TemplateId { get; set; }
        public int? GroupId { get; set; }
        public int? SubGroupId { get; set; }
        public string? AuthorId { get; set; }
        public int? IndicatorId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Order { get; set; }
        public int? CriticalQuestionValue { get; set; }
        public string Type { get; set; } = "3"; // Asspciated with metadata
        public string Status { get; set; } = "2"; // Asspciated with metadata
        public string Critical { get; set; } = "2"; // Asspciated with metadata
        public string CalculationType { get; set; } = "1"; // Asspciated with metadata
        public decimal GlobalWeight { get; set; }
        public decimal IndicatorWeight { get; set; }
        public int? QuestionEvaluationControlId { get; set; }
    }

    public class PostQuestionItemDTO
    {
        public string ControlType { get; set; } = "4"; // Asspciated with metadata Questions
        public string? Size { get; set; } // Use example of down, USE NUMBER
        public string? Label { get; set; }
        public int QuestionId { get; set; }

        /*
         public enum Size
         {
             Small = 1,
             Medium = 2,
             Large = 3
         }
         */
    }

    public class PostQuestionItemListValueDTO
    {
        public string? Value { get; set; }
        public int Order { get; set; }
        public int QuestionItemId { get; set; }
    }
}
