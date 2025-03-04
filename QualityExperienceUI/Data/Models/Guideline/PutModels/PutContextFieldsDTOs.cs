using System.Drawing;

namespace QualityExperienceUI.Data.Models.Guideline.PutModels
{
    public class PutContextFieldsTypesDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Label { get; set; }
        public string? Size { get; set; }
        public int MaxLength { get; set; }
        public int Order { get; set; }
        public bool Required { get; set; }
        public bool Visible { get; set; }

        /*
         public enum Size
        {
            Small = 1,
            Medium = 2,
            Large = 3
        }
         */
    }
}
