namespace QualityExperienceUI.Data.Models.GetModels
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

    public class SimpleClientListDTO
    {
        public int id { get; set; }
        public string? name { get; set; }
    }

    public class GetClientByIdDTO
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public string? status { get; set; }
        public int? countryID { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public List<TemplatesToClientByID>? templates { get; set; }
    }

    public class TemplatesToClientByID
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
    }
}
