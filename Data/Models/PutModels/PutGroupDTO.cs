namespace QualityExperienceUI.Data.Models.PutModels
{
    public class PutGroupDTO
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public int templateId { get; set; }
        public int parentId { get; set; }
        public int order { get; set; }
        public int authorId { get; set; }
    }
}
