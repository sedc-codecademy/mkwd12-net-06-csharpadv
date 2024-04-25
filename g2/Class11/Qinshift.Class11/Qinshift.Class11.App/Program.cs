using Newtonsoft.Json;
using Qinshift.Class11.Domain.Model;
using Qinshift.Class11.Service;

string directoryPath = @"..\..\..\OurData";
string filePath = directoryPath + @"\ourJson.json";

if(!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);

//if(!File.Exists(filePath)) File.Create(filePath).Close();

ReaderWriter readerWriter = new ReaderWriter();
OurJsonSerlizer OurJsonSerlizer = new OurJsonSerlizer();

Student bob = new Student()
{
    FirstName = "Bob",
    LastName = "Bobsky",
    Age = 27,
    isPartTime = false
};

#region Our serialize / deserialize methods
string bobString = OurJsonSerlizer.SerilizeStudent(bob);
readerWriter.WriteFile(filePath, bobString);
string jsonStudent = readerWriter.ReadFile(filePath);
Student deserializeStudent = OurJsonSerlizer.DeserializeStudent(jsonStudent);
Console.WriteLine(deserializeStudent.FirstName);
Console.WriteLine(deserializeStudent.LastName);
Console.WriteLine(deserializeStudent.Age);
Console.WriteLine(deserializeStudent.isPartTime);
Console.ReadLine();
#endregion

#region Newtonsoft JSON serialize / deserialize
string bobSerilizedNewtonsoft = JsonConvert.SerializeObject(bob);

Console.WriteLine(bobSerilizedNewtonsoft);

Student bobDeserilizedNewtonsoft = JsonConvert.DeserializeObject<Student>(bobSerilizedNewtonsoft);

Console.WriteLine(bobDeserilizedNewtonsoft.FirstName);
Console.WriteLine(bobDeserilizedNewtonsoft.LastName);
Console.WriteLine(bobDeserilizedNewtonsoft.Age);
Console.WriteLine(bobDeserilizedNewtonsoft.isPartTime);

Console.ReadLine();
#endregion