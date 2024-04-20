string folderPath = @"..\..\..\Exercise";
string filePath = @"..\..\..\Exercise\calculations.txt";

string Calculate(int num1, int num2)
{
    return $"{num1} + {num2} = {num1 + num2}";
}

try
{
    Console.WriteLine("Enter first number");
    string firstInput = Console.ReadLine();

    Console.WriteLine("Enter second number");
    string secondInput = Console.ReadLine();

    string result = Calculate(int.Parse(firstInput), int.Parse(secondInput));

    if (!Directory.Exists(folderPath))
    {
        Directory.CreateDirectory(folderPath);
    }

    using(StreamWriter sw = new StreamWriter(filePath, true)) //we want to append the text in the file
    {
        sw.WriteLine($"{DateTime.Now: dd.MM.yyyy HH.mm.ss} : {result}");
        sw.WriteLine("=======================================");
    }

}
catch(Exception e)
{
    Console.WriteLine("An error occured");
    Console.WriteLine(e.Message);
}