using System.ComponentModel.DataAnnotations;

namespace QualityExperienceUI.Data.Models.PostModels
{
    public class PostClientDTO
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public int countryID { get; set; }

    }
}
