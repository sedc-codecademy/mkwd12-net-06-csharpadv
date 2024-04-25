using DisposingClasses;
using System.Security.Cryptography;

string appPath = @"..\..\..\Example";
string filePath = appPath + @"\example.txt";


#region ManualDispose
void AppendtextToFile(string text, string filePath)
{
    //streamWriter checks if there is a file on the given path
    //if the file exists it will write in it
    //if the file does not exist it will create it and then write in it
    StreamWriter writer = new StreamWriter(filePath, true);
    writer.WriteLine(text);
    //StreamWriter implements IDisposable interface. That means that it implements the Dispose method
    //Thios method has to be called, so that the writer object is destroyed and the connection to the file system is closed
    //Here, we need to call this method explicitlu, since we don't have an using block

    //we can make sure that this is always executed, even if an error happens if we wrap the code in try-catch-finally  and put it in the finaly
    writer.Dispose(); 

    //StreamWriter sw = new StreamWriter(filePath, true);
    //sw.Dispose();
}

void ReadTextFromFile(string filePath)
{
    StreamReader reader = new StreamReader(filePath);
    string text = reader.ReadToEnd();
    Console.WriteLine(text);
    //StreamReader implements IDisposable interface. That means that it implements the Dispose method
    //Thios method has to be called, so that the writer object is destroyed and the connection to the file system is closed
    //Here, we need to call this method explicitlu, since we don't have an using block
    reader.Dispose();
}

if (!Directory.Exists(appPath))
{
    Directory.CreateDirectory(appPath);
}

try
{
    AppendtextToFile("Hello world", filePath);
    ReadTextFromFile(filePath);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion


#region Dispose with using block
void AppendTextInFileWithUsing(string text, string filePath)
{
    using(StreamWriter writer = new StreamWriter(filePath, true))
    {
        writer.WriteLine(text);
    } //here (when using block ends) writer.Dispose() is automatically called, we don't  have to worry about exceptions, or if we are disposing the correct resource
      //it is automatically done for us
}

void ReadFromFileWithUsing(string filePath)
{
    using(StreamReader reader = new StreamReader(filePath))
    {
        string text = reader.ReadToEnd();
        Console.WriteLine(text);
    }//here (when using block ends) reader.Dispose() is automatically called
}

try
{
    Console.WriteLine("================================");
    AppendTextInFileWithUsing("Hello G6", filePath);
    ReadFromFileWithUsing(filePath);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion

#region Dispose with Custom class

void AppendTextToFileUsingCustomWriter(string text, string filePath)
{
    //Our CustomWriter implements IDisposable interface
    //it has an impl of Dispose method so we can use it in using block
    using(CustomWriter cw = new CustomWriter(filePath))
    {
       
        cw.Write(text);

    } //here the Dispose method from our CustomWriter, with our impl will be called
}

AppendTextToFileUsingCustomWriter("Hello from custom writer", filePath);
AppendTextToFileUsingCustomWriter("stop", filePath);

#endregion