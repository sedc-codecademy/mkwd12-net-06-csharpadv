using Serilog;

namespace Class09_LoggerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(@"Logs\logs-.txt", rollingInterval: RollingInterval.Minute)
                .MinimumLevel.Information()
                .CreateLogger();

            for (var i = 0; i < 10; i++)
            {
                var s1 = new Student("Risto", "Panchevski");
                Thread.Sleep(10000);
            }            
        }
    }
}
