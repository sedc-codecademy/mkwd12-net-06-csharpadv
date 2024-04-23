namespace Serialization.Entities
{
    public class ReaderWriter
    {
        public string ReadFile(string path)
        {
            string result = "";
            if(!File.Exists(path))
            {
                return "File does not exist!";
            }

            using(StreamReader reader = new StreamReader(path, true))
            {
                result = reader.ReadToEnd();
            }
            Console.WriteLine("Successfully read a file!");
            return result;
        }

        public void WriteFile(string path, string data)
        {
            using(StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(data);
            }
            Console.WriteLine("Successfully written a file!");
        }
    }
}
