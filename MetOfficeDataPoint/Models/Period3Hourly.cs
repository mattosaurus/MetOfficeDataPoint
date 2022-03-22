using System.Text.Json.Serialization;

namespace MetOfficeDataPoint.Models
{
    public class Period3Hourly
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        public List<Rep3Hourly> Rep { get; set; }
    }
}