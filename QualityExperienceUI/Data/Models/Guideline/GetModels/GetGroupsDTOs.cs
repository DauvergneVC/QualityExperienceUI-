namespace QualityExperienceUI.Data.Models.Guideline.GetModels
{
    public class GetGroupsDTO
    {
        /* 
         * Obtine la lista de grupos
         */
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int TemplateId { get; set; }
        public int GroupId { get; set; }
        public int AuthorId { get; set; }
        public int Order { get; set; }
        public int GroupType { get; set; }
    }

    public class GetGroupsByTemplateDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? GroupType { get; set; }
        public int TemplateId { get; set; }
        public int Order { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
