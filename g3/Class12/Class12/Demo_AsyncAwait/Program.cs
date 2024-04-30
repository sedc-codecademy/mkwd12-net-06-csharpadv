namespace Demo_AsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetMessage1();
            Console.WriteLine("End of the main");
            Thread.Sleep(10000);
        } 

        public static async Task GetMessage()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Enter GetMessage");
                Thread.Sleep(5000);
                Console.WriteLine("End of GetMessage");
            });
        }

        public static async void GetMessage1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Enter GetMessage1");
                Thread.Sleep(5000);
                Console.WriteLine("End of GetMessage1");
            });
        }
    }
}
