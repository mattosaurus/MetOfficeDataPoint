using MetOfficeDataPoint.Helpers;
using System.Text.Json.Serialization;

namespace MetOfficeDataPoint.Models
{
    public class ForecastLocation3Hourly
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
        [JsonConverter(typeof(SingleOrArrayConverter<Period3Hourly>))]
        public List<Period3Hourly> Period { get; set; }
    }
}