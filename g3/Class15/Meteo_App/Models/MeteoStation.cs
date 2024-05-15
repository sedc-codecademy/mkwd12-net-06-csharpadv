using Newtonsoft.Json;

namespace Models
{
    public delegate void MeteoDelegate(WeatherModel model);

    public class MeteoStation
    {
        public string Name { get; set; }
        public event MeteoDelegate Medias;

        public void Subscribe(MeteoDelegate func)
        {
            if(Medias == null || Medias.GetInvocationList().Length == 0)
            {
                Medias = func;
            } else
            {
                Medias += func;
            }
        }

        public void UnSubscribe(MeteoDelegate func)
        {
            if (Medias != null && Medias.GetInvocationList().Length > 0)
            {
                Medias -= func;
            }
        }

        public async Task<WeatherModel> GetMeteoData()
        {
            var result = await GetWeatherStat();

            Medias(result);

            return result;
        }

        private async Task<WeatherModel> GetWeatherStat()
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
