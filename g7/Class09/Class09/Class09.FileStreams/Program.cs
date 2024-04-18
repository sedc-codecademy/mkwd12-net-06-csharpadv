

string appPath = @"..\..\..\";
string folderPath = appPath + @"myFolder\";
string filePath = folderPath + @"test.txt";

if(!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("New directory was created!");
}

//Writing with streamwriter
using (StreamWriter sw = new StreamWriter(filePath))
{
    sw.WriteLine("Hello Quinshift!");
    sw.WriteLine("We are writing text from StreamWriter!");
    Console.WriteLine("Writing is complete!");
}

// Writing without rewriting the document with StreamWriter
using (StreamWriter sw = new StreamWriter(filePath))
{
    sw.WriteLine("Hello from outer space!");
    sw.WriteLine("We are writing text from a galaxy far far away!");
    Console.WriteLine("Writing is complete!");
}

using (StreamWriter sw = new StreamWriter(filePath, true))
{
    sw.WriteLine("Hello Quinshift!");
    sw.WriteLine("We are writing text from StreamWriter!");
    Console.WriteLine("Writing is complete!");
}

Console.ReadLine();

using(StreamReader sr = new StreamReader(filePath))
{
    string firstLine = sr.ReadLine();
    string secondLine = sr.ReadLine();
    string restContent = sr.ReadToEnd();
    Console.WriteLine($"First Line {firstLine}");
    Console.WriteLine($"Second Line {secondLine}");
    Console.WriteLine("Rest of content in the file bellow");
    Console.WriteLine($"{restContent}");
}