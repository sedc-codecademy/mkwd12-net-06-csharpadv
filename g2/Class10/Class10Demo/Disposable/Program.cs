
using Disposable;
using Helpers;

ExtendedConsole.PrintInColor("\n================= DISPOSING =================\n\n", ConsoleColor.Cyan);


const string FolderPath = @"..\..\..\Example\Text";
const string FilePath = FolderPath + @"\text.txt";

void CreateFolder(string path)
{
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
}

void CreateFile(string filePath)
{
    if (!File.Exists(filePath))
    {
        File.Create(filePath).Close();
    }
}

CreateFolder(FolderPath);
CreateFile(FilePath);


#region Manual Dispose Methods
void AppendTextInFile(string text, string filePath)
{
    StreamWriter sw = new StreamWriter(path: filePath, append: true);
    sw.WriteLine(text);
    sw.Dispose(); // will throw exception if we don't call Dispose()
}

void ReadTextFromFile(string filePath)
{
    StreamReader sr = new StreamReader(filePath);
    Console.WriteLine(sr.ReadToEnd());
    sr.Dispose();
}

void ManualDisposeExample()
{
    ExtendedConsole.PrintInColor("Enter text pt1: ");
    string text1 = Console.ReadLine();
    AppendTextInFile(text1, FilePath);

    ExtendedConsole.PrintInColor("Enter text pt2: ");
    string text2 = Console.ReadLine();
    AppendTextInFile(text2, FilePath);

    ExtendedConsole.PrintInColor("Enter text pt3: ");
    string text3 = Console.ReadLine();
    AppendTextInFile(text3, FilePath);

    Console.ReadLine();
    ExtendedConsole.PrintInColor("----------- Read -----------\n");
    ReadTextFromFile(FilePath);
}

#endregion


#region Dispose with *using* block
void AppendTextInFileSave(string text, string filePath)
{
    using (StreamWriter sw = new StreamWriter(filePath, true))
    {
        sw.WriteLine(text);
        // sw.Dispose(); // we don't need to call Dispose explicitly
    }
}

void ReadTextFromFileSave(string filePath)
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        Console.WriteLine(sr.ReadToEnd());
    }
    //using StreamReader sr = new StreamReader(filePath);
    //Console.WriteLine(sr.ReadToEnd());
}

void UsingDisposeExample()
{
    ExtendedConsole.PrintInColor("Enter text pt1: ");
    string text1 = Console.ReadLine();
    AppendTextInFileSave(text1, FilePath);

    ExtendedConsole.PrintInColor("Enter text pt2: ");
    string text2 = Console.ReadLine();
    AppendTextInFileSave(text2, FilePath);

    ExtendedConsole.PrintInColor("Enter text pt3: ");
    string text3 = Console.ReadLine();
    AppendTextInFileSave(text3, FilePath);

    Console.ReadLine();
    ExtendedConsole.PrintInColor("----------- Read -----------\n");
    ReadTextFromFileSave(FilePath);
}

#endregion


#region Dispose with our own Disposable class
void AppendTextInFileCustomImplementation(string text, string filePath)
{
    OurWriter writer = new OurWriter(filePath);
    writer.Write(text);
    writer.Dispose();
    //using (OurWriter ow = new OurWriter(filePath))
    //{
    //    ow.Write(text);
    //}
}

void ReadTextFromFileCustomImplementation(string filePath)
{
    using (OurReader or = new OurReader(filePath))
    {
        Console.WriteLine(or.Read());
    }
}

void CustomDisposeExample()
{
    ExtendedConsole.PrintInColor("Enter text pt1: ");
    string text1 = Console.ReadLine();
    AppendTextInFileCustomImplementation(text1, FilePath);

    ExtendedConsole.PrintInColor("Enter text pt2: ");
    string text2 = Console.ReadLine();
    AppendTextInFileCustomImplementation(text2, FilePath);

    ExtendedConsole.PrintInColor("Enter text pt3: ");
    string text3 = Console.ReadLine();
    AppendTextInFileCustomImplementation(text3, FilePath);

    Console.ReadLine();
    ExtendedConsole.PrintInColor("----------- Read -----------\n");
    ReadTextFromFileCustomImplementation(FilePath);
}


#endregion


//ManualDisposeExample();
//UsingDisposeExample();
CustomDisposeExample();

Console.ReadLine();