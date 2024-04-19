using System.IO;
using System;

#region DirectoryManipulation

string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory);

//Relative path to our application folder
string appPath = @"..\..\..\";

//Absolute path to our app folder
//something like C:Users\Source\folder1\Folder2... ... ...

// Check if a folder exists 
bool myFolderExists = Directory.Exists(appPath + @"myFolder");
bool myFolderExistsAbsolute = Directory.Exists(@"C:\Users\Source\folder1\Folder2");
Console.WriteLine($"Does my folder exists: {myFolderExists}");

// Create a new folder
string newFolder = appPath + @"newFolder";
Console.WriteLine($"Does newFolder exists before: {Directory.Exists(newFolder)}");
if(!Directory.Exists(newFolder))
{
    Directory.CreateDirectory(newFolder);
    Console.WriteLine("New directory was created!");
}

Console.WriteLine($"Does newFolder exists after {Directory.Exists(newFolder)}");

Console.WriteLine("Press anything to delete neFolder...");
Console.ReadLine();

//Delete a directory
if(Directory.Exists(newFolder))
{
    Directory.Delete(newFolder);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("newFolder was DELETED!");
    Console.ResetColor();
}
Console.ReadLine();

#endregion

//FileManipulation
string filesPath = appPath + @"myFolder\";
if(!Directory.Exists(filesPath))
{
    Directory.CreateDirectory(filesPath);
    Console.WriteLine("New directory was created!");
}

bool testTxtExists = File.Exists(filesPath + @"test.txt");
bool test2TxtExists = File.Exists(filesPath + @"test2.txt");
Console.WriteLine($"does test.tx exists: {testTxtExists}");
Console.WriteLine($"does test2.tx exists: {test2TxtExists}");

if(!File.Exists(filesPath + @"test.txt"))
{
    File.Create(filesPath + @"test.txt").Close();
    Console.WriteLine("A file was Created");
}

//Console.WriteLine("To delete this file press anything");
//Console.ReadLine();

////File Delete!
//if(File.Exists(filesPath + @"\test.txt"))
//{
//    File.Delete(filesPath + @"\test.txt");
//    Console.WriteLine("A file was deleted!");
//}
//Console.ReadLine();

//Writing in a file
string testTxtPath = filesPath + @"test.txt";
if (File.Exists(testTxtPath))
{
    File.WriteAllText(testTxtPath, "Hello Quishift! We are writing in a file!");
    Console.WriteLine("Successfully written in a file!");
}
Console.ReadLine();

//Read from a file
if(File.Exists(testTxtPath))
{
    string content = File.ReadAllText(testTxtPath);
    Console.WriteLine("This is the text that we read from the file:");
    Console.WriteLine(content);
}
Console.ReadLine();


