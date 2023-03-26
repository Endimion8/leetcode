using System.Text.Json.Serialization;

namespace SetStreamsAndSpecializations
{
    public class StreamModel
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}