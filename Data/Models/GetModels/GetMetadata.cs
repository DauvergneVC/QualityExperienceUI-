namespace QualityExperienceUI.Data.Models.GetModels
{
    public class GetQuestionMetadataDTO
    {
        public List<string>? questionType { get; set; }
        public List<string>? questionStatus { get; set; }
        public List<string>? criticalQuestion { get; set; }
        public List<string>? calculationQuestionType { get; set; }
        public List<string>? evaluationControl { get; set; }
    }
}
