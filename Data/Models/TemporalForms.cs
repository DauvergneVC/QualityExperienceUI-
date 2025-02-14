namespace QualityExperienceUI.Data.Models
{

    public class CreateIndicatorDTO
    {
        public string name { get; set; }
        public string description { get; set; }
        public int order { get; set; }
        public string type { get; set; }
        public int forCalculation { get; set; }
    }

    public class CreateQuestionsDTO
    {
        public int templateID { get; set; }
        public int groupID { get; set; }
        public int subGroupID { get; set; }
        public int authorID { get; set; }
        public int indicatorID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int order { get; set; }
        public int criticalQuestionValue { get; set; }
        public int type { get; set; }
        public int status { get; set; }
        public int critical { get; set; }
        public int calculationType { get; set; }
        public int globalWeight { get; set; }
        public int indicatorWeight { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int questionEvaluationControlID { get; set; }
    }

    public class CreateQuestionsItemDTO
    {
        public int controlType { get; set; }
        public int controlSize { get; set; }
        public string label { get; set; }
        public int questionID { get; set; }
    }

    public class CreateServiceDTO
    {
        public string name { get; set; }
        public string description { get; set; }
        public int templateID { get; set; }
        public int order { get; set; }
        public int authorID { get; set; }
        public int serviceCategoryID { get; set; }
        public int serviceType { get; set; }
        public int operationType { get; set; }
        public int status { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

    public class CreateServiceCategorieDTO
    {
        public string name { get; set; }
        public string description { get; set; }
        public int order { get; set; }
        public int authorID { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
