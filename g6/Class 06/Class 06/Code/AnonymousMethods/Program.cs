using System.Globalization;

List<string> names = new List<string>() { "Petko", "Stefan", "Nikola", "Jana" };

//Func => used to store method that returns a value and can have no params or have params
//we are reading from left to right, Func<int, string, bool> means we have a function with two params 
//of type int and string and returns a bool


//we are storing anonymous method that takes one param of type List<string> and returns bool
Func<List<string>, bool> checkIfListIsEmpty = (list) => list.Count == 0;

bool isEmpty = checkIfListIsEmpty(names);

//Func ALWAYS has a return type, so this is a function that has no params and returns a value of type int
Func<int> sumOfTwoAndFive = () => 2 + 5;
Console.WriteLine(sumOfTwoAndFive());

//two int params and returns an int value
Func<int, int, int> sum = (x, y) => x + y;
Console.WriteLine(sum(3, 5));

//if we have many lines of code in the body of the anonymous method, we use {}
Func<int, int, bool> isFirstnumberLarger = (x, y) =>
{
    if (x > y)
        return true;
    else return false;
};

List<int> ints = new List<int>() { 2, 5, 7, 8, 9 };
List<int> secondListInts = new List<int>() { 2, 5, 46, 8, 34 };

Func<int, bool> checkEven = x => x %2 == 0;

List<int> evenNumbers = ints.Where(checkEven).ToList();
//we can reuse checkEven so we don't need to write the check every time
List<int> evenNumbersFromSecondList = secondListInts.Where(checkEven).ToList();

Func<string, bool> startsWithJ = x => x.StartsWith("J");

List<string> namesStartingWithJ = names.Where(startsWithJ).ToList();

//Action - Action is ALWAYS void

Action sayHello = () => Console.WriteLine("Hello");

Action<string> printRed = x =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(x);
    Console.ResetColor();
};

printRed("Hello G6");

Action<string, ConsoleColor> printColor = (message, color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ResetColor();
};


printColor("We are learning C# and it's hard and fun", ConsoleColor.Green);
