namespace Class09_DemoFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string absolutePath = @"C:\SEDC\2024\Basic C#\Code\\G3\Class09";
            string relativePath = @"..\Folder\file1.txt";

            var currentPath = Directory.GetCurrentDirectory();
            Console.WriteLine(currentPath);

            //var exists = Directory.Exists(@"C:\SEDC\2024\C# Advance\Code\g3\Class09\Test");

            //Directory.CreateDirectory(@"C:\SEDC\2024\C# Advance\Code\g3\Class09\Test1");

            //if(!Directory.Exists(@"C:\SEDC\2024\C# Advance\Code\g3\Class09\Test"))
            //{
            //    Directory.CreateDirectory(@"C:\SEDC\2024\C# Advance\Code\g3\Class09\Test");
            //}

            //if(!Directory.Exists(@"..\Files"))
            //{
            //    Directory.CreateDirectory(@"..\Files");
            //}

            //File.Create(@"Files\text.docx");

            List<string> students = new List<string> { "Risto", "Slave", "Sasho" };
            var folderPath = "Documents";
            var filePath = @$"{folderPath}\students.txt";

            //File.AppendAllText(@"Documents\file2.txt", "Simple text");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if(!File.Exists(filePath))
            {
                FileStream file = File.Create(filePath);
                file.Close();
            }

            File.WriteAllText(filePath, "Simple text");
            File.WriteAllText(filePath, "Something else");

            File.WriteAllLines(filePath, students);

            File.AppendAllText(filePath, "New text added");
            File.AppendAllLines(filePath, students);

            var text = File.ReadAllText(filePath);
            var textLines = File.ReadAllLines(filePath).ToList();

            var newTextLines = textLines.Select((x, index) => $"{index + 1}. {x}").ToList();

            File.WriteAllLines(filePath, newTextLines);

            File.Delete(filePath);
            Directory.Delete("Documents", true);
        }
    }
}
