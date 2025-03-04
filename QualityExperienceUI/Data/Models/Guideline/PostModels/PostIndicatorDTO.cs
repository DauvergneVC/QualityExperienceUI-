namespace QualityExperienceUI.Data.Models.Guideline.PostModels
{
    public class PostIndicatorDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Order { get; set; }
        public string? Type { get; set; }
        public string? ForCalculation { get; set; } // Yes(1) or No(0), USE NUMBER

        /*
         In BackEnd
        public enum ForCalculation
        {
            Yes = 1,
            No = 0
        }
         */
    }
}
