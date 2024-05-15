using System.Collections.Generic;
using System;
using Examples;

#region SimplerSwitchStatement

void PrintMessage(MessageTypeEnum color, string message)
{
    ConsoleColor consoleColor = color switch
    {
        MessageTypeEnum.Warning => ConsoleColor.Yellow,
        MessageTypeEnum.Error => ConsoleColor.Red,
        MessageTypeEnum.Info => ConsoleColor.Blue,
        MessageTypeEnum.Success => ConsoleColor.Green,
        //in any other case, default is typed with _ symbol
        _ => throw new ArgumentException(message: "Invalid enum value")
    };
    Console.ForegroundColor = consoleColor;
    Console.WriteLine(message);
    Console.ResetColor();
}

while (true)
{
	try
	{
		Console.WriteLine("You have the unmbers 8 and 2. Enter operation for calculationg: ( -, +, * or / )");
		string operation = Console.ReadLine();
		int result = operation switch
		{
            // the case is +
            // what will happen => 8 + 2
            "+" => 8 + 2,
			//the case is -
			//what will happen => 8 - 2
            "-" => 8 - 2,
            "*" => 8 * 2,
            "/" => 8 / 2,
			//default _
			_ => throw new ArgumentException(message: "Invalid operation")
        };
		PrintMessage(MessageTypeEnum.Success, $"The result is {result}");
	}
	catch (Exception ex)
	{
		PrintMessage(MessageTypeEnum.Error, ex.Message);
	}
	PrintMessage(MessageTypeEnum.Info, "Do you want to try again? Y/N");
	string choice = Console.ReadLine();
	if (choice.ToLower() == "y") continue;
	break;
}

#endregion

#region PatternMatching

double ComputeArea(object shape)
{
    if (shape is Square)
    {
        Square s = (Square)shape;
        return s.Side * s.Side;
    }
    else if (shape is Circle)
    {
        Circle c = (Circle)shape;
        return c.Radius * c.Radius * Math.PI;
    }
    else if (shape is Triangle)
    {
        Triangle t = (Triangle)shape;
        return (t.Height * t.Base) / 2;
    }
    throw new ArgumentException(
        message: "shape is not a recognized shape",
        paramName: nameof(shape));
}

double ComputeAreaNew(object shape)
{
    if (shape is Square s) return s.Side * s.Side;
    else if (shape is Circle c) return c.Radius * c.Radius * Math.PI;
    else if (shape is Rectangle r) return r.Height * r.Length;
    else if (shape is Triangle t) return (t.Height * t.Base) / 2;
    throw new ArgumentException(
        message: "shape is not a recognized shape",
        paramName: nameof(shape));
}

// Older is =>
try
{
    Square sq = new Square(5);
    Console.WriteLine($"Area of square with side 5 is: {ComputeArea(sq)}");

    RandomShape rs = new RandomShape(1, 2, 3, 4);
    Console.WriteLine($"Area of random shape with sides 1, 2, 3 and 4 is: {ComputeArea(rs)} ");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadLine();

// Modern is =>
try
{
    Triangle tr = new Triangle(5, 6);
    Console.WriteLine($"Area of square with side 5 is: {ComputeAreaNew(tr)}");

    RandomShape rs = new RandomShape(1, 2, 3, 4);
    Console.WriteLine($"Area of random shape with sides 1, 2, 3 and 4 is: {ComputeAreaNew(rs)} ");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadLine();

#endregion

#region Tuples

// Using a tuple as a paramter
int Sum(Tuple<int, int> numbers)
{
    return numbers.Item1 + numbers.Item2;
}

while (true)
{
    try
    {
        // Ways of creating a tuple
        Tuple<string, string, int> tempPerson1 = Tuple.Create("Bob", "Bobsky", 33);
        Tuple<string, string, int> tempPerson2 = new Tuple<string, string, int>("Bob", "Bobsky", 33);

        Console.WriteLine($"Welcome {tempPerson1.Item1} {tempPerson1.Item2} - {tempPerson1.Item3} years old!");
        Console.WriteLine("Enter number:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number:");
        int num2 = int.Parse(Console.ReadLine());

        // Using a tuple as an argument
        Console.WriteLine($"{num1} + {num2} = {Sum(Tuple.Create(num1, num2))}");
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ResetColor();
    }
    Console.WriteLine("Do you want to try again? Y/N");
    string choice = Console.ReadLine();
    Console.Clear();
    if (choice.ToLower() == "y") continue;

    break;
}

#endregion

#region DefaultLiteral

List<T> CreateList<T>(int length, T initialValue = default)
{
    if (length <= 0) return default;
    var list = new List<T>();
    for (int i = 0; i < length; i++)
    {
        list.Add(initialValue);
    }
    return list;
}

// Simple example
int integerValue = default;
bool booleanValue = default;
decimal decimalValue = default;
string stringValue = default;
List<string> listOfStringsValue = default;

Console.WriteLine($"{integerValue} - Type: {integerValue.GetType().Name}");
Console.WriteLine($"{booleanValue} - Type: {booleanValue.GetType().Name}");
Console.WriteLine($"{decimalValue} - Type: {decimalValue.GetType().Name}");
Console.WriteLine($"{stringValue} - IsNull: {stringValue == null}");
Console.WriteLine($"{listOfStringsValue} - IsNull: {listOfStringsValue == null}");
Console.ReadLine();

List<string> newListWithValues = CreateList<string>(6, "Bob");
List<int> newListWithIntsDefault = CreateList<int>(10);
List<bool> newListWithBoolsDefault = CreateList<bool>(5);
List<decimal> newListDecimalWithLengthZero = CreateList<decimal>(0);

Console.WriteLine($"Type Of List = {newListWithValues.GetType().Name} of {newListWithValues[0].GetType().Name} and the items in it are {newListWithValues[0]}");
Console.WriteLine($"Type Of List = {newListWithIntsDefault.GetType().Name} of {newListWithIntsDefault[0].GetType().Name} and the items in it are {newListWithIntsDefault[0]}");
Console.WriteLine($"Type Of List = {newListWithBoolsDefault.GetType().Name} of {newListWithBoolsDefault[0].GetType().Name} and the items in it are {newListWithBoolsDefault[0]}");
Console.WriteLine($"Is Null: {newListDecimalWithLengthZero == null}");

Console.ReadLine();

#endregion