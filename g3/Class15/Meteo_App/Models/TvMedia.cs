using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TvMedia
    {
        public string Name { get; set; }

        public void ProcessLatestMeteoData(WeatherModel model)
        {
            Console.WriteLine($"[{Name}] Weather forecast!");
            Console.WriteLine($"Current temp: {model.CurrentData.Temperature} {model.CurrentUnits.TemperatureUnit}");
        }
    }
}
