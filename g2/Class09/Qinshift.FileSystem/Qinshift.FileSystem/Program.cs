#region DirectoryManipulation
using System.IO;

string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory);

//Absolute path

string absolutePath = @"C:\Users\Danilo Borozan\Desktop\C#\Class09\Qinshift.FileSystem\Qinshift.FileSystem\myFolder";


bool myFolderExistsWithAbsolutePath = Directory.Exists(absolutePath);
Console.WriteLine("================================");

Console.WriteLine($"Does myFolder exists: {myFolderExistsWithAbsolutePath}");

//Relative path
string relativePath = @"..\..\..\";

bool myFolderExistsWithRealtivePath = Directory.Exists(relativePath + "myFolder");

Console.WriteLine($"Does myFolder exists: {myFolderExistsWithRealtivePath}");

//Create a new Folder
string newFolder = relativePath + "newFolder";

if (!Directory.Exists(newFolder))
{
    Directory.CreateDirectory(newFolder);
    Console.WriteLine("New directory was created!");
}
Console.WriteLine($"Does newFolder exists: {newFolder}");

Console.ReadLine();

Console.WriteLine("====  Directory DELETE ===");
string oldFolder = relativePath + "oldFolder";
if (Directory.Exists(oldFolder))
{
    Directory.Delete(oldFolder);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("oldFOlder was DELETED!");
    Console.ResetColor();
}
Console.ReadLine();

#endregion

#region FileManipulation
string filesPath = relativePath + @"myFolderWithFile\";
if (!Directory.Exists(filesPath))
{
    Directory.CreateDirectory(filesPath);
    Console.WriteLine("Directory was created!!!");
}

bool textFileExists = File.Exists(filesPath + @"test.txt");
Console.WriteLine($"Does test.txt exists: {textFileExists}");

//File Create
if (!textFileExists)
{
    File.Create(filesPath + @"test.txt").Close();
    Console.WriteLine("File was created!!!!");
}
Console.ReadLine();

//Writing a text
string testPath = filesPath + @"test.txt";
string test2Path = filesPath + @"test2.txt";
string content = "Hello SEDC!!!!";
if (File.Exists(testPath))
{
    File.WriteAllText(testPath, "Hello Qinshift!!! We are writing in a file.");
    Console.WriteLine("Successfully writen in a file!");
}

if (File.Exists(testPath))
{
    File.WriteAllText(testPath, content);
    Console.WriteLine("Successfully writen in a file!");
}

if (File.Exists(testPath))
{
    File.AppendAllText(testPath, "Hello Qinshift!!! We are writing in a file.");
    Console.WriteLine("Successfully writen in a file!");
}
Console.ReadLine();

//Read from a file
if (File.Exists(testPath))
{
    string contentFromFile = File.ReadAllText(testPath);
    Console.WriteLine("This is a text from a file");
    Console.WriteLine(contentFromFile);
}
Console.ReadLine();

//Delete file
bool textFileExists2 = File.Exists(filesPath + @"test2.txt");
if (!textFileExists2)
{
    File.Create(filesPath + @"test2.txt").Close();
    Console.WriteLine("File was created!!!!");
}
Console.ReadLine();

if (File.Exists(test2Path))
{
    File.Delete(test2Path);
    Console.WriteLine("File was deleted");
}
Console.ReadLine();
#endregion