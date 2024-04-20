

string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory); //absolute path //C:\Users\stoja\OneDrive\Desktop\SEDC\C# Advanced 2024\Class 10\Code\WorkingWithFileSystem\bin\Debug\net6.0

//relative path to console app folder
string appPath = @"..\..\..\";

//check if this path exists ..\..\..\myFolder -> check if three levels above exists a folder called myFolder
bool myFolderExists = Directory.Exists(appPath + "myFolder");
Console.WriteLine(myFolderExists);

//..\..\..\newFolder
string newFolderPath = appPath + "newFolder";
if (!Directory.Exists(newFolderPath))
{
    Directory.CreateDirectory(newFolderPath);
    Console.WriteLine("New folder successfully created");
}

Console.WriteLine("New folder exists: "+ Directory.Exists(newFolderPath));

if (Directory.Exists(newFolderPath))
{
    Directory.Delete(newFolderPath);
    Console.WriteLine("New folder deleted");
}
Console.WriteLine("New folder exists: " + Directory.Exists(newFolderPath));

//Wortking with files
if(!Directory.Exists(appPath + "myFolder"))
{
    Directory.CreateDirectory(appPath + "myFolder");
    Console.WriteLine("My folder successfully created");
}

//check if a file test.txt exists on ..\..\..\myFolder\test.txt
bool testTxtExists = File.Exists(appPath + @"myFolder\test.txt");
Console.WriteLine("Test txt exists " +  testTxtExists);

if (!testTxtExists)
{
    File.Create(appPath + @"myFolder\test.txt").Close();
    Console.WriteLine("test.txt was created");
}

if (File.Exists(appPath + @"myFolder\test.txt")){
    //overwite the content of test.txt
    File.WriteAllText(appPath + @"myFolder\test.txt", "Hello G6");
}

if (File.Exists(appPath + @"myFolder\test.txt"))
{
    //overwite the content of test.txt
    File.WriteAllText(appPath + @"myFolder\test.txt", "Hello G6 again! This is another text");
}

if (File.Exists(appPath + @"myFolder\test.txt"))
{
    //append text to the content of test.txt
    //with Environment.NewLine we make sure that the new line will work on any environment
    //it will take the shortcut from the current environment
    File.AppendAllText(appPath + @"myFolder\test.txt", Environment.NewLine + "Goodbye G6");
}

if (File.Exists(appPath + @"myFolder\test.txt"))
{
    //append text to the content of test.txt
    //with Environment.NewLine we make sure that the new line will work on any environment
    //it will take the shortcut from the current environment
    File.AppendAllText(appPath + @"myFolder\test.txt", Environment.NewLine + "See you \n on Tuesday");
}

if (File.Exists(appPath + @"myFolder\test.txt"))
{
    //we need to tell the path that we want to read from
    string fileContent = File.ReadAllText(appPath + @"myFolder\test.txt");
    Console.WriteLine("File content:");
    Console.WriteLine(fileContent);
}

if (File.Exists(appPath + @"myFolder\test.txt"))
{
    //we need to specify the path to our file
    File.Delete(appPath + @"myFolder\test.txt");
}