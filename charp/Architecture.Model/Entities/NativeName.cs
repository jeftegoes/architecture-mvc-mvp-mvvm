using System.Text.Json.Serialization;

namespace Architecture.Model.Entities
{
    public class NativeName
    {
        [JsonPropertyName("ara")]
        public Ara Ara { get; set; }
    }
}