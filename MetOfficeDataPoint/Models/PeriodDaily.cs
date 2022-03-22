using MetOfficeDataPoint.Helpers;
using System.Text.Json.Serialization;

namespace MetOfficeDataPoint.Models
{
    public class PeriodDaily
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("Rep")]
        [JsonConverter(typeof(DayNightConverter<RepDaily>))]
        public RepDaily Rep { get; set; }
    }
}