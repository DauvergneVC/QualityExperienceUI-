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
