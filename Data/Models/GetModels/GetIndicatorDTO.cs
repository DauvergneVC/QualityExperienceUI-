namespace QualityExperienceUI.Data.Models.GetModels
{
    public class GetIndicatorDTO
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int order { get; set; }
        public string? type { get; set; }
        public string? forCalculation { get; set; }
    }
}
