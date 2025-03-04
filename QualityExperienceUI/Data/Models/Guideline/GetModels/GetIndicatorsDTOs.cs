namespace QualityExperienceUI.Data.Models.Guideline.GetModels
{
    public class GetIndicatorsDTO
    {
        // Same for get all Indicators and get indicators by ID
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Order { get; set; }
        public string? Type { get; set; }
        public string? ForCalculation { get; set; }
    }
}