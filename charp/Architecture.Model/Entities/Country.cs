using System.Text.Json.Serialization;

namespace Architecture.Model.Entities
{
    public class Country
    {
        [JsonPropertyName("name")]
        public Name Name { get; set; }
    }
}
