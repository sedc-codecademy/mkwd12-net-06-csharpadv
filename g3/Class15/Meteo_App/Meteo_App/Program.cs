using Models;
using Services;

namespace Meteo_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var meteoStation = new MeteoStation() { Name = "Meteo stanica" };
                var tv1 = new TvMedia() { Name = "Sitel" };
                var tv2 = new TvMedia() { Name = "Telma" };
                var radio1 = new RadioMedia() { Name = "Antena5" };

                meteoStation.Subscribe(tv1.ProcessLatestMeteoData);
                meteoStation.Subscribe(tv2.ProcessLatestMeteoData);
                meteoStation.Subscribe(radio1.ProcessLatestMeteoData);

                var result = meteoStation.GetMeteoData().Result;
            }
            catch
            {
                var t = 1;
            }
        }
    }
}
