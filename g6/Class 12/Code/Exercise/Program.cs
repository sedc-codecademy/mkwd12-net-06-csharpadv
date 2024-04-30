using Exercise;
using Newtonsoft.Json;

string folderPath = @"..\..\..\Data";
string filePath = $@"{folderPath}\dogs.json";

//check if Directory and File exist, if not -> create them

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
}

List<Dog> dogs;

//we need to check if the file already contains a list of dogs - if we should take that list and add the new dogs to that list
using(StreamReader sr = new StreamReader(filePath))
{
    string content = sr.ReadToEnd();
    dogs = JsonConvert.DeserializeObject<List<Dog>>(content);

    //if the file does not already contain dogs, we should create an empty list
    if(dogs == null)
    {
        dogs = new List<Dog>(); //we cannot say dogs.Add if dogs is null (null.Add will throw an error)
    }
}

//loop where the user enter info about the dog(s)
while (true)
{
    Console.WriteLine("Please enter your Dog info:");
    Console.WriteLine("Name:");
    string name = Console.ReadLine();
    Console.WriteLine("Color:");
    string color = Console.ReadLine();

    Console.WriteLine("Age:");

    if(!int.TryParse(Console.ReadLine(), out int age))
    {
        Console.WriteLine("Wrong input for age, please enter a number");
        continue; //it will skip this iteration and go back to line 32 and enter the next iteration
    }

    Dog dog = new Dog(name, color, age);
    dogs.Add(dog);
    Console.WriteLine("Do you want to enter a new dog (y)?");
    string choice = Console.ReadLine();

    if (choice != "y")
    {
        break; //it will end the loop
    }
}

//we need to write our list in our file dogs.json
using (StreamWriter sw = new StreamWriter(filePath))
{
    //we need to serialize our List<Dog> into JSON
    string result = JsonConvert.SerializeObject(dogs);
    sw.Write(result);
}