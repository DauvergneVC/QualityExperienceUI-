namespace QualityExperienceUI.Data.Models.Guideline.PostModels
{
    public class PostClientDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int CountryId { get; set; }  // Associated with GetCountries
    }
}
