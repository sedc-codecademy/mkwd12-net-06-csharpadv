namespace Models
{
    public class RadioMedia
    {
        public string Name { get; set; }

        public void ProcessLatestMeteoData(WeatherModel model)
        {
            Console.WriteLine($"[{Name}] Weather forecast!");
            Console.WriteLine($"Average temp: {model.HourlyData.Temperatures.Average()} {model.CurrentUnits.TemperatureUnit}");
        }
    }
}
