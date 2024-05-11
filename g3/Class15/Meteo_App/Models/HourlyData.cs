using Newtonsoft.Json;

namespace Models
{
    public class HourlyData
    {
        [JsonProperty("time")]
        public List<DateTime> Periods { get; set; }
        [JsonProperty("temperature_2m")]
        public List<decimal> Temperatures { get; set; }
    }
}
