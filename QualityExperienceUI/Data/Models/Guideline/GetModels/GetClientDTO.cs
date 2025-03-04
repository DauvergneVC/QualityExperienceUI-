namespace QualityExperienceUI.Data.Models.Guideline.GetModels
{
    public class GetClientDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public int CountryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class GetClientByIdDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public int CountryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<TemplateResponse>? Templates { get; set; }


        // Associated sub class
        public class TemplateResponse
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Description { get; set; }
        }
    }


}
