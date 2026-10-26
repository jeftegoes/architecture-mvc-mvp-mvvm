using System.Text.Json.Serialization;

namespace Architecture.Model.Entities
{
    public class Ara
    {
        [JsonPropertyName("official")]
        public string Official { get; set; }

        [JsonPropertyName("common")]
        public string Common { get; set; }
    }
}
