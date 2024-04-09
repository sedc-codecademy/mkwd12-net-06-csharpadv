Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n================ ANONYMOUS METHODS ================\n");
Console.ResetColor();


List<string> names = new() { "Bob", "Jill", "Wayne", "Greg", "John", "Anne" };

List<string> empty = new();

string johnName = names.Find(name => name == "John"); // one line lambda expression

// Lambda expression (arrow function): name => name == "John"
// => anonymous method with one parameter (*name*) and return value of type bool (*name == "John"* returns bool)

// multi-line lambda expression
string johnName2 = names.Find(name =>
{
    if (name == "John")
    {
        return true;
    }
    return false;
});


// let method = (num1, num2) => num1 + num2;
// method(2,5) // 7

#region Func
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\n================ Func ================\n");
Console.ResetColor();
// Func => type of delegate 
// => defines the type of a method (what type and how many parameters will it have and what is the return type)
// => always has a return value ! (the type of the return value is always the last type in the < > brackets)

// ===> Example of Func with no parameters
Func<bool> isNamesEmpty = () => names.Count == 0;
Console.WriteLine("Is names empty " + isNamesEmpty());

// ===> Example of Func with 1 parameter
// List<string> -> parameter no. 1 / bool -> return type
Func<List<string>, bool> isListEmpty = (list) => list.Count == 0;
Console.WriteLine(isListEmpty(names));
Console.WriteLine(isListEmpty(empty));

// ===> Example of Func with 2 parameters
// int -> parameter no. 1 / int -> parameter no. 2 / int -> return type
Func<int, int, int> sum = (num1, num2) => num1 + num2;
Console.WriteLine("Sum of 5 and 8 is " + sum(5, 8));

// Check if number is even or odd
Func<int, bool> isNumberEven = number => number % 2 == 0;
Console.WriteLine(isNumberEven(4));
Console.WriteLine(isNumberEven(3));


// ===> Example of Func with 4 parameters
Func<int, string, double, bool, string> getUserInfo = (id, name, salary, isActive) =>
{
    //return true; // ERROR -> the return type must be string
    return $"ID: {id}. Name {name}. Salary {salary}. Is Active {isActive}";
};
string userInfo = getUserInfo(1, "Bob", 333.33, true);
Console.WriteLine("User Bob info: " + userInfo);

// Func<void> printHello = () => Console.WriteLine("Hello"); // ERROR! Func must have a return value, it cannot be void !!!
#endregion



#region Action
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\n================ Action ================\n");
Console.ResetColor();
// Action is also delegate that is always void !


// ===> Example of Action without parameters
Action printHello = () => Console.WriteLine("Hello :)");
printHello();

// ===> Example of Action with 1 parameter (string)
Action<string> printRed = text =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
};

//printRed(123); // ERROR
printRed("An error occured!");

// ===> Example of Action with 2 parameters (string, ConsoleColor)
Action<string, ConsoleColor> printInColor = (text, color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
    //return 123; // ERROR ! Action delegate doesn't return value
};

printInColor("Don't worry it's okay", ConsoleColor.Green);

#endregion


#region Using Func & Action with LINQ
printInColor("\n============ Using Func & Action ============\n", ConsoleColor.Yellow);

string foundJill = names.FirstOrDefault(name => name == "Jill");

Func<List<string>, string, string> getName = (list, name) => list.FirstOrDefault(n => n == name);
Console.WriteLine(getName(names, "Jill"));

Func<string, bool> hasJill = name => name == "Jill";
foundJill = names.FirstOrDefault(hasJill);
Console.WriteLine(foundJill);


// All starting with the letter "J"
Func<string, bool> namesStartingWithJ = name => name.StartsWith("J");

List<string> letterJNames = names.Where(namesStartingWithJ).ToList();
//foreach (string name in letterJNames)
//{
//    Console.WriteLine(name);
//}
letterJNames.ForEach(name => printInColor(name, ConsoleColor.Blue));



#endregion