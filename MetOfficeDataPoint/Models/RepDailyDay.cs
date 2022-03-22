using System.Text.Json.Serialization;

namespace MetOfficeDataPoint.Models
{
    public class RepDailyDay
    {
        [JsonPropertyName("D")]
        public string WindDirection { get; set; }

        [JsonPropertyName("Gn")]
        public int WindGustNoon { get; set; }

        [JsonPropertyName("Hn")]
        public int ScreenRelativeHumidityNoon { get; set; }

        [JsonPropertyName("PPd")]
        public int PrecipitationProbabilityDay { get; set; }

        [JsonPropertyName("S")]
        public int WindSpeed { get; set; }

        [JsonPropertyName("V")]
        public string Visibility { get; set; }

        [JsonPropertyName("Dm")]
        public int DayMaximumTemperature { get; set; }

        [JsonPropertyName("FDm")]
        public int FeelsLikeDayMaximumTemperature { get; set; }

        [JsonPropertyName("W")]
        public int WeatherType { get; set; }

        [JsonPropertyName("U")]
        public int MaxUVIndex { get; set; }

        [JsonPropertyName("$")]
        public string Type { get; set; }
    }
}