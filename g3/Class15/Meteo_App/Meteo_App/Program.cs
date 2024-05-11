using Services;

namespace Meteo_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IMeteoService _meteoService = new MeteoService();
                var t = _meteoService.GetWeatherStat().Result;
            }
            catch
            {
                var t = 1;
            }
        }
    }
}
