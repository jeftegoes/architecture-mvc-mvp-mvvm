using System.Text.Json.Serialization;

namespace Architecture.Model.Entities
{
    public class Name
    {
        [JsonPropertyName("common")]
        public string Common { get; set; }

        [JsonPropertyName("official")]
        public string Official { get; set; }

        [JsonPropertyName("nativeName")]
        public NativeName NativeName { get; set; }
    }
}
