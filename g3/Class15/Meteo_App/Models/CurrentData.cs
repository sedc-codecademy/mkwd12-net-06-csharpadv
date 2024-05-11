using Newtonsoft.Json;

namespace Models
{
    public class CurrentData
    {
        [JsonProperty("temperature_2m")]
        public decimal Temperature { get; set; }
        [JsonProperty("wind_speed_10m")]
        public decimal WindSpeed { get; set; }
    }
}
