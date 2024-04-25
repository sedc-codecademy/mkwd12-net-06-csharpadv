using Newtonsoft.Json;
using SerializationDeserialization;

string folderPath = @"..\..\..\Example";
string filePath = folderPath + @"\jsonfile.json";

Student student = new Student()
{
    FirstName = "Marko",
    LastName = "Markovski",
    Age = 30,
    IsPartTime = true
};

CustomReaderWriter readerWriter = new CustomReaderWriter();

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

//1. serialize the student object to JSON
string jsonStudent = CustomSerializerDeserializer.SerializeStudent(student);

//2. write JSON to file
readerWriter.WriteToFile(filePath, jsonStudent);

//3. read json from file
string jsonFromFile = readerWriter.ReadFromFile(filePath);

//4. parse (deserialize) the read json
Student parsedStudent = CustomSerializerDeserializer.DeserializeStudent(jsonFromFile);

//USING Newronsoft.JSON
//we need the library (package) from nuget pacakage manager
//we can install it for a concrete project or multiple projects
//to install it right click on solution or project -> manage nuget packages

Student anotherStudent = new Student()
{
    FirstName = "Petko",
    LastName = "Petkovski",
    Age = 25,
    IsPartTime = false
};

//1. serialize the student object to JSON
string jsonString = JsonConvert.SerializeObject(anotherStudent);

//2.write to file
readerWriter.WriteToFile(filePath, jsonString);

//3. read json from file
string jsonFileContent = readerWriter.ReadFromFile(filePath);

//4. parse (deserialize) the read json
Student studentPetko = JsonConvert.DeserializeObject<Student>(jsonFileContent);




List<int> integers = new List<int> { 5, 6, 7, 7 };
string jsonList = JsonConvert.SerializeObject(integers);

List<int> parsedIntegers = JsonConvert.DeserializeObject<List<int>>(jsonList);

