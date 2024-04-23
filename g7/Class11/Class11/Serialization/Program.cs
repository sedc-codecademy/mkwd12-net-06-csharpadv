using Newtonsoft.Json;
using Serialization.Entities;

string directoryPath = @"..\..\..\OurData";
string filePath = directoryPath + @"\myFirstJson";
OurJsonSerializer Serializer = new OurJsonSerializer();
ReaderWriter ReaderWriter = new ReaderWriter();

#region Serialization with our own serialize/deserialize methods

//1 way
if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);

//2 way
if (!Directory.Exists(directoryPath))
    Directory.CreateDirectory(directoryPath);

//3 way
//if (!Directory.Exists(directoryPath))
//{
//    Directory.CreateDirectory(directoryPath);
//}

Student bob = new Student()
{
    FirstName = "Bob",
    LastName = "Bobsky",
    Age = 40,
    IsPartTime = true
};

//string bobString = Serializer.SerializeStudent(bob);
//ReaderWriter.WriteFile(filePath, bobString);
//string jsonStudent = ReaderWriter.ReadFile(filePath);
//Student deserializedStudent = Serializer.DeserializeStudent(jsonStudent);
//Console.WriteLine(deserializedStudent.Age);
//Console.ReadLine();

#endregion

#region Newtonsoft JSON serialize / deserialize 

// JsonConvert comes from Newtonsoft nuget package
string bobSerializedNewtonsoft = JsonConvert.SerializeObject(bob);
//Console.WriteLine($"{bobSerializedNewtonsoft.FirstName}"); // we cannot use props because now its json string not an object
Console.WriteLine(bobSerializedNewtonsoft);

Student bobDeserializedNewtonsoft = JsonConvert.DeserializeObject<Student>(bobSerializedNewtonsoft);
Console.WriteLine(bobDeserializedNewtonsoft.FirstName);
Console.ReadLine();

#endregion