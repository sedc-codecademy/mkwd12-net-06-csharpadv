using Newtonsoft.Json;

namespace Class11_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Data";
            string filePath = $@"{folderPath}\dogs.json";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            List<Dog> dogs;

            using(var sr = new StreamReader(filePath))
            {
                var content = sr.ReadToEnd();
                dogs = JsonConvert.DeserializeObject<List<Dog>>(content);

                if(dogs == null)
                {
                    dogs = new List<Dog>();
                }
            }

            while (true)
            {
                Console.WriteLine("Please enter your Dog info.");
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Color: ");
                var color = Console.ReadLine();
                Console.Write("Age: ");
                
                if(!int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.WriteLine("Wrong input for age, please enter a number!");
                    continue;
                }

                var dog = new Dog(name, color, age);
                dogs.Add(dog);

                Console.Write("Do you want to enter new dog (y)? ");
                var choice = Console.ReadLine();

                if (choice.ToLower() != "y") break;
            }

            using(var sw = new StreamWriter(filePath))
            {
                var result = JsonConvert.SerializeObject(dogs);
                sw.WriteLine(result);
            }

        }
    }
}
