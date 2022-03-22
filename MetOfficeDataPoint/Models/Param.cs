using System.Text.Json.Serialization;

namespace MetOfficeDataPoint.Models
{
    public class Param
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("units")]
        public string Units { get; set; }

        [JsonPropertyName("$")]
        public string Description { get; set; }
    }
}