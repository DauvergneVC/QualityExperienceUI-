namespace QualityExperienceUI.Data.Models.PostModels
{
    public class PostContextFieldTypesdDTO
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public string? label { get; set; }
        public string? size { get; set; }
        public int maxLength { get; set; }
        public int order { get; set; }
        public bool required { get; set; }
        public bool visible { get; set; }
        public int templateId { get; set; }
    }

    public class PostContextFieldValuesDTO
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public int contextFieldTypeId { get; set; }
    }
}
