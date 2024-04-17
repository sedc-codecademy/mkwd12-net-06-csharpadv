namespace Class09_DemoStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = "Documents";
            string filePath = $@"{folderPath}\products.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                var file = File.Create(filePath);
                file.Close();
            }

            //StreamWriter sw = new StreamWriter(filePath);
            //sw.Write("New text");
            //sw.Close();

            //StreamWriter sw1 = new StreamWriter(filePath, true);
            //sw1.Write("Another text");
            //sw1.Close();

            using (var sw = new StreamWriter(filePath))
            {
                sw.WriteLine("New text");
            }

            using (var sw = new StreamWriter(filePath, true))
            {

                //sw.Write($"{sw.NewLine} Another text");
                sw.WriteLine("Another text");
                sw.WriteLine("Another text1");
                sw.WriteLine("Another text2");
            }

            using (var sr = new StreamReader(filePath))
            {
                //var line1 = sr.ReadLine();
                //var line2 = sr.ReadLine();
                //var line3 = sr.ReadToEnd();
                //var line4 = sr.ReadLine();
                //var line5 = sr.ReadLine();


                //while (!sr.EndOfStream)
                while (true)
                {
                    string s = sr.ReadLine();
                    Console.WriteLine(s);
                    Thread.Sleep(3000);
                    if (s == null)
                    {
                        break;
                    }
                }
            }
        }
    }
}
