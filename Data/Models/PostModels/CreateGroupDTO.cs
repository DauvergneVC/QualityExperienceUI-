namespace QualityExperienceUI.Data.Models.PostModels
{
    public class CreateGroupDTO
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public int templateID { get; set; }
        public int order { get; set; }
        public int authorID { get; set; }
    }
}
