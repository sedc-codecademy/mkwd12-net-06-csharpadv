string appPath = @"..\..\..\";
string myFolder = appPath + "myFolder";
string txtpath = myFolder + @"\test.txt";

if (!Directory.Exists(myFolder))
{
    Directory.CreateDirectory(myFolder);
}

//if the test.txt file does not exists, the stream writer creates it for us
using(StreamWriter sw = new StreamWriter(txtpath))
{
    sw.WriteLine("Hello G6");
    sw.WriteLine("We are writing from stream writer");
}
//sw only exists and can be used in the using block {}
//after the } sw object is disposed and the connection with the file system is closed

//here we are opening a new strem
//if thewe is alredy some text it will be overwritten
using(StreamWriter sw = new StreamWriter(txtpath))
{
    sw.WriteLine("Another text");
    sw.WriteLine("This is another line");
    sw.WriteLine("This is another text line");
}

//here we are saying that we want to append the text to the existing text in the file
using(StreamWriter sw = new StreamWriter(txtpath, true)) 
{
    sw.WriteLine("This is appended text");
}

//reading
using(StreamReader sr = new StreamReader(txtpath))
{
    string firstLine = sr.ReadLine();//this way we only read one line from the file
    string secondLine = sr.ReadLine();
    string restOfText = sr.ReadToEnd(); //read the rest of the text in the file to the end of the file

    Console.WriteLine(firstLine);
    Console.WriteLine(secondLine);
    Console.WriteLine(restOfText);
}