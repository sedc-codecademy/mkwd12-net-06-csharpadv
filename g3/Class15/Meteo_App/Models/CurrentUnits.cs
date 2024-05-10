using Newtonsoft.Json;

namespace Models
{
    public class CurrentUnits
    {
        [JsonProperty("temperature_2m")]
        public string TemperatureUnit { get; set; }
        [JsonProperty("wind_speed_10m")]
        public string WindSpeedUnit { get; set; }
    }
}
