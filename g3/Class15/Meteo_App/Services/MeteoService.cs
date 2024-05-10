using Models;
using Newtonsoft.Json;
using System.Net;

namespace Services
{
    public class MeteoService : IMeteoService
    {
        public async Task<WeatherModel> GetWeatherStat()
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(
                    "https://api.open-meteo.com/v1/forecast?latitude=41.99&longitude=21.42&current=temperature_2m,wind_speed_10m&hourly=temperature_2m");
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadAsStringAsync();

                var temperatureData = JsonConvert.DeserializeObject<WeatherModel>(result);

                return temperatureData;
            }
        }
    }
}
