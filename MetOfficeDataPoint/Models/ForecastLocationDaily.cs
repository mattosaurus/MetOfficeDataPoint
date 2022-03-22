using System.Text.Json.Serialization;

namespace MetOfficeDataPoint.Models
{
    public class ForecastLocationDaily
    {
        [JsonPropertyName("i")]
        public int LocationId { get; set; }

        [JsonPropertyName("lat")]
        public double Latitude { get; set; }

        [JsonPropertyName("lon")]
        public double Longitude { get; set; }

        [JsonPropertyName("name")]
        public string LocationName { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("continent")]
        public string Continent { get; set; }

        [JsonPropertyName("elevation")]
        public double Elevation { get; set; }

        [JsonPropertyName("Period")]
        public List<PeriodDaily> Period { get; set; }
    }
}