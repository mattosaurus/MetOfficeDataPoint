using System.Text.Json.Serialization;

namespace MetOfficeDataPoint.Models
{
    public class Location
    {
        [JsonPropertyName("elevation")]
        public double Elevation { get; set; }

        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("unitaryAuthArea")]
        public string UnitaryAuthorityArea { get; set; }
    }
}