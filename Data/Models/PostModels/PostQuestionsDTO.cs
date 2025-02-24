using System.Drawing;
using System.Security.AccessControl;

namespace QualityExperienceUI.Data.Models.PostModels
{
    public class PostQuestionsDTO
    {
        public int TemplateId {get; set;}
        public int? GroupId {get; set;}
        public int? SubGroupId {get; set;}
        public int AuthorId {get; set;}
        public int? IndicatorId {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public int Order {get; set;}
        public int? CriticalQuestionValue {get; set;}
        public string Type {get; set;}
        public string Status {get; set;}
        public string Critical {get; set;}
        public string CalculationType {get; set;}
        public decimal GlobalWeight {get; set;}
        public decimal IndicatorWeight {get; set;}
        public int? QuestionEvaluationControlID { get; set; }
    }

    public class PostQuestionItemDTO
    {
        public string? ControlType { get; set; }
        public string? Size { get; set; }
        public string Label { get; set; }
        public int QuestionId { get; set; }


        //AccessControlType:
        //    DropdownSingle = 1,
        //DropdownMultiple = 2,
        //TextArea = 3,
        //Text = 4, 
        //Number = 5,
        //Color = 6,
        //Email = 7,
        //Date = 8,
        //Time = 9

        //Size:
        //    Small = 1,
        //Medium = 2,
        //Large = 3
    }

    public class PostQuestionItemListValue
    {
        public string? Value { get; set; }
        public int Order { get; set; }
        public int QuestionItemId { get; set; }
    }
}
