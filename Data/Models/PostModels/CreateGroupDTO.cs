namespace QualityExperienceUI.Data.Models.PostModels
{
    public class CreateGroupDTO : BasePost
    {
        public int templateID { get; set; }
        public int parentID { get; set; }
        public int order { get; set; }
        public int authorID { get; set; }
    }
}
