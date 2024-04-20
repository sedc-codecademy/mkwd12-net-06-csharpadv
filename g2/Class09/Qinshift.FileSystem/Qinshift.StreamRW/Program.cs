using System.IO;

string appPath = @"..\..\..\";
string folderPath = appPath + @"myFolder\";
string filePath = folderPath + @"test.txt";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("New directory was created!");
}
// Writing with StreamWriter
using (StreamWriter sw = new StreamWriter(filePath))
{
    sw.WriteLine("HELLOOOOO SEDC!!!!");
    sw.WriteLine("We are writing text with StreamWriter");
    sw.WriteLine("Writing is complete!");
    sw.Write("BYE BYE");
    sw.Write("BYE BYE");
    Console.WriteLine("Successfully writen in a file!");
}
// Writing without rewriting the document with StreamWriter
using (StreamWriter sw = new StreamWriter(filePath, true))
{
    sw.WriteLine("HELLOOOOO SEDC!!!!");
    sw.WriteLine("We are writing text with StreamWriter");
    sw.WriteLine("Writing is complete!");
    sw.Write("BYE BYE");
    sw.Write("BYE BYE");
    Console.WriteLine("Enter text:");
    sw.WriteLine(Console.ReadLine());
    Console.WriteLine("Successfully writen in a file!");
}


// Reading with StreamReader

using(StreamReader sr = new StreamReader(filePath))
{
    string firstLine = sr.ReadLine();
    string secondLine = sr.ReadLine();
    string restContent = sr.ReadToEnd();
    Console.WriteLine($"First line: {firstLine}");
    Console.WriteLine($"Second line: {secondLine}");
    Console.WriteLine($"Rest Content: {restContent}");
}
Console.ReadLine();