namespace QualityExperienceUI.Data.Models.GetModels
{
    public class GetContextFieldTypesDTO
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public string? label { get; set; }
        public string? size { get; set; }
        public int maxLength { get; set; }
        public int order { get; set; }
        public bool required { get; set; }
        public bool visible { get; set; }
        public int templateId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

    public class GetConextxFielValuesdDTO
    {
        public int id { get; set; }
        public string? name { get; set; }
        public int contextFieldTypeId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
