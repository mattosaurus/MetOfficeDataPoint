using System.Text.Json.Serialization;

namespace MetOfficeDataPoint.Models
{
    public class RepDailyNight
    {
        [JsonPropertyName("D")]
        public string WindDirection { get; set; }

        [JsonPropertyName("Gm")]
        public int WindGustMidnight { get; set; }

        [JsonPropertyName("Hm")]
        public int ScreenRelativeHumidityMidnight { get; set; }

        [JsonPropertyName("PPn")]
        public int PrecipitationProbabilityNight { get; set; }

        [JsonPropertyName("S")]
        public int WindSpeed { get; set; }

        [JsonPropertyName("V")]
        public string Visibility { get; set; }

        [JsonPropertyName("Nm")]
        public int NightMinimumTemperature { get; set; }

        [JsonPropertyName("FNm")]
        public int FeelsLikeNightMinimumTemperature { get; set; }

        [JsonPropertyName("W")]
        public int WeatherType { get; set; }

        [JsonPropertyName("$")]
        public string Type { get; set; }
    }
}