namespace Class10_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = "Data";
            string filePath = @$"{folderPath}\customText.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if(!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            for (var i = 0; i < 1; i++)
            {
                //var customWritter = new CustomWrtiter(filePath);

                //customWritter.WriteLine($"[{DateTime.Now}] This is our first line", 1);
                //customWritter.WriteLine($"[{DateTime.Now}] This is our second line", 2);
                //customWritter.Dispose();

                using (var customWritter = new CustomWrtiter(filePath))
                {
                    customWritter.WriteLine($"[{DateTime.Now}] This is our first line", 1);
                    customWritter.WriteLine($"[{DateTime.Now}] This is our second line", 2);
                }
            }

            //Thread.Sleep(5000);
            //GC.Collect();
            //Thread.Sleep(5000);

            using(var sr = new StreamReader(filePath))
            {
                var text = sr.ReadToEnd();
            }
        }
    }
}
