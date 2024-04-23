

using Disposable;
using System.Security;

#region fileManagement

string AppPath = @"..\..\..\";
string FilePath = AppPath + @"\text.txt";

void CreateFolder(string path)
{
    if(!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
}

void CreateFile(string path)
{
    if (!File.Exists(path))
    {
        File.Create(path).Close();
    }
}

#endregion

#region Manual Dispose methods
//Manual Dispose Methods
void AppendTextInFile(string text, string path)
{
    StreamWriter sw = new StreamWriter(path, true);
    if (text == "break") throw new Exception("Something broke unexpectedly...");
    sw.WriteLine(text);
    sw.Dispose(); //this method will release the unneccecary resourses
}

void ReadTextFromFile(string path)
{
    StreamReader sr = new StreamReader(path);
    Console.WriteLine(sr.ReadToEnd());
    sr.Dispose(); //this method will release the unneccecary resourses
}

void ManualExample()
{
    try
    {
        Console.WriteLine("Enter text pt1:");
        string text1 = Console.ReadLine();
        AppendTextInFile(text1, FilePath);
        Console.WriteLine("Enter text pt2:");
        string text2 = Console.ReadLine();
        AppendTextInFile(text2, FilePath);
        Console.WriteLine("Enter text pt3:");
        string text3 = Console.ReadLine();
        AppendTextInFile(text3, FilePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was a problem in the writing system");
        Console.WriteLine(ex.Message);
    }

    try
    {
        Console.ReadLine();
        Console.WriteLine("-------------Read-----------");
        ReadTextFromFile(FilePath);
    }
    catch (Exception e)
    {
        Console.WriteLine("There was a problem in the writing system");
        Console.WriteLine(e.Message);
    }

    Console.ReadLine();
}
#endregion

#region Dispose with using block

void AppendTextInFileSafe(string text, string path)
{
    using(StreamWriter sw = new StreamWriter(path, true))
    {
        if (text == "break") throw new Exception("Something broke unexpectedly...");
        sw.WriteLine(text);
    }
}

void ReadtTextFromFileSafe(string path)
{
    using(StreamReader sr = new StreamReader(path))
    {
        Console.WriteLine(sr.ReadToEnd());
    }
}

void UsingExample()
{
    try
    {
        Console.WriteLine("Enter text pt1:");
        string text1 = Console.ReadLine();
        AppendTextInFile(text1, FilePath);
        Console.WriteLine("Enter text pt2:");
        string text2 = Console.ReadLine();
        AppendTextInFile(text2, FilePath);
        Console.WriteLine("Enter text pt3:");
        string text3 = Console.ReadLine();
        AppendTextInFile(text3, FilePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was a problem in the writing system");
        Console.WriteLine(ex.Message);
    }

    try
    {
        Console.ReadLine();
        Console.WriteLine("-------------Read-----------");
        ReadTextFromFile(FilePath);
    }
    catch (Exception e)
    {
        Console.WriteLine("There was a problem in the writing system");
        Console.WriteLine(e.Message);
    }

    Console.ReadLine();
}

#endregion

#region Dispose with our own classes

void AppendTextInFileOurImplementation(string text, string path)
{
    using (OurWriter ow = new OurWriter(path))
    {
        if (text == "break") throw new Exception("Something broke unexpectedly...");
        ow.Write(text);
    }
}

void ReadTextFromFileOurImplementation(string path)
{
    using (OurReader or = new OurReader(path))
    {
        Console.WriteLine(or.Read());
    }
}

void OurDisposableExample()
{
    try
    {
        Console.WriteLine("Enter text pt1:");
        string text1 = Console.ReadLine();
        AppendTextInFile(text1, FilePath);
        Console.WriteLine("Enter text pt2:");
        string text2 = Console.ReadLine();
        AppendTextInFile(text2, FilePath);
        Console.WriteLine("Enter text pt3:");
        string text3 = Console.ReadLine();
        AppendTextInFile(text3, FilePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was a problem in the writing system");
        Console.WriteLine(ex.Message);
    }

    try
    {
        Console.ReadLine();
        Console.WriteLine("-------------Read-----------");
        ReadTextFromFile(FilePath);
    }
    catch (Exception e)
    {
        Console.WriteLine("There was a problem in the writing system");
        Console.WriteLine(e.Message);
    }

    Console.ReadLine();
}

#endregion

//ManualExample();
//UsingExample();
OurDisposableExample();