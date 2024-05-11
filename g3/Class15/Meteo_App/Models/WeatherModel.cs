using Newtonsoft.Json;

namespace Models
{
    public class WeatherModel
    {
        [JsonProperty("latitude")]
        public decimal Latitude { get; set; }
        [JsonProperty("longitude")]
        public decimal Longitude { get; set; }
        [JsonProperty("current_units")]
        public CurrentUnits CurrentUnits { get; set; }
        [JsonProperty("current")]
        public CurrentData CurrentData { get; set; }
        [JsonProperty("hourly")]
        public HourlyData HourlyData { get; set; }
    }
}
