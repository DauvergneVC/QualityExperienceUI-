namespace QualityExperienceUI.Data.Models.PutModels
{
    public class PutServiceDTO
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public int order { get; set; }
        public int authorID { get; set; }
        public int serviceCategoryID { get; set; }
        public string? serviceType { get; set; }
        public string? operationType { get; set; }
        public string? status { get; set; }

    }

    public class PutServiceCategoryDTO
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public int order { get; set; }
        public int authorID { get; set; }
    }
}
