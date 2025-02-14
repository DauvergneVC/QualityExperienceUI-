namespace QualityExperienceUI.Data.Models.GetModels
{
    public class GetGroupListDTO
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int templateId { get; set; }
        public int groupId { get; set; }
        public int authorId { get; set; }
        public int order { get; set; }
        public int groupType { get; set; }
    }

    public class GetGroupMetadataDTO
    {
        public List<MetadataNameValue> groupType { get; set; } = new();

    }
}
