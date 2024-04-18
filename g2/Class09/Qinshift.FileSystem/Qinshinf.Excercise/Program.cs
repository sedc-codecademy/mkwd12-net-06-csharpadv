using System.IO;
using System;

string filesPath = @"../../../Exercise";
string fileName = "calculations.txt";

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Please enter first number:");
    string input1 = Console.ReadLine();

    Console.WriteLine("Please enter second number:");
    string input2 = Console.ReadLine();

    int a = ConvertToInt(input1);
    int b = ConvertToInt(input2);

    WriteIntoFile(FormatResult(a, b, Calculate(a, b)));
}

ReadFromFile();

static int ConvertToInt(string input)
{
    if (!int.TryParse(input, out int number))
    {
        throw new Exception("Wrong input");
    }

    return number;
}

static int Calculate(int number1, int number2)
{
    return number1 + number2;
}

string FormatResult(int number1, int number2, int result)
{
    return $"{DateTime.Now:dd.MM.yyyy HH:mm:ss} - {number1} + {number2} = {result}";
}

void WriteIntoFile(string content)
{
    if (!Directory.Exists(filesPath))
    {
        Directory.CreateDirectory(filesPath);
    }

    using (StreamWriter sw = new StreamWriter(Path.Combine(filesPath, fileName), true))
    {
        sw.WriteLine(content);
    }
}

void ReadFromFile()
{
    using (StreamReader sr = new StreamReader(Path.Combine(filesPath, fileName)))
    {
        for (string line = sr.ReadLine(); line != null; line = sr.ReadLine())
        {
            Console.WriteLine(line);
        }
    }
}