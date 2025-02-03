namespace QualityExperienceUI.Data.Models
{
    public class ClientListDTO
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public string? status { get; set; }
        public int? countryID { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
    }
}
