

void CheckOperation(int num1, int num2, string operation)
{
    switch (operation)
    {
        case "+":
            Console.WriteLine($"{num1} {operation} {num2} = {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"{num1} {operation} {num2} = {num1 - num2}");
            break;
        default:
            Console.WriteLine($"The app doesnt work with {operation}");
            break;
    }
}

void NoOptional(int num1, int num2, string operation)
{
    Console.WriteLine("Calling NoOptinalMethod");
    CheckOperation(num1, num2, operation);
}

void SomeOptional(int num1, int num2, string operation = "+")
{
    Console.WriteLine("Calling SomeOptinalMethod");
    CheckOperation(num1, num2, operation);
}

void AllOptional(int num1 = 5, int num2 = 10, string operation = "+")
{
    Console.WriteLine("Calling AllOptinalMethod");
    CheckOperation(num1, num2, operation);
}

NoOptional(2, 3, "+");
//NoOptional(2, 3); // this will not work, will miss third parameter
SomeOptional(2, 3);
SomeOptional(5, 3, "-");
AllOptional(); // it will get the default values for num1 = 5, num2 = 10, operation = "+"
AllOptional(1);
AllOptional(1, 5);
AllOptional(12, 5, "-");

NoOptional(num2: 3, operation: "+", num1: 10); // will work since all arguments are named
NoOptional(10, operation: "-", num2: 3); // here it will work since our arguments are names and it knows exacly what argumets corresponds to which parameter
//NoOptional(10, "-", 3); // this will not work since the order of the arguments is wrong

#region MoreExamples for students to and try out and debug if needed
//WriteInConsole("Hello from SEDC");

//WriteInConsoleOptional();

//WriteInConsoleOptional("Hello from SEDC");

//WriteInConsoleThirdWay("Hello from SEDC");
//Console.ReadLine();

//WriteInConsoleThirdWay("Hello from SEDC", ConsoleColor.Red);
//Console.ReadLine();

//WriteInConsoleThirdWay("Hello from SEDC", ConsoleColor.Blue, ConsoleColor.Cyan);
//Console.ReadLine();

//WriteInConsoleThirdWay("Hello from SEDC", ConsoleColor.Green, ConsoleColor.Yellow, true);

WriteInConsoleThirdWay("Hello from", showSedcAtEnd: true);


// this was is ok
WriteInConsoleThirdWay(showSedcAtEnd: true, msg: "Hello from Msg as named param");

// this is not ok 
//WriteInConsoleThirdWay(showSedcAtEnd: true, "Hello from Msg as named param");

//WriteInConsoleThirdWay(msg: "Named param 1", showSedcAtEnd: false, ConsoleColor.Red);

//WriteInConsoleThirdWay("Unnamed param", ConsoleColor.Yellow, showSedcAtEnd: true, foregroundColor: ConsoleColor.Blue);

//WriteInConsoleOtherWay("Hello From Sedc", null, null, true);

void WriteInConsole(string msg)
{
    Console.WriteLine(msg);
}

void WriteInConsoleOptional(string msg = "SEDC")
{
    Console.WriteLine(msg);
    // some logic here
}

void WriteInConsoleThirdWay(string msg, // required
    ConsoleColor backgroundColor = ConsoleColor.Black, // optional
    ConsoleColor foregroundColor = ConsoleColor.White, // optional
    bool showSedcAtEnd = false) // optional
{
    Console.BackgroundColor = backgroundColor;
    Console.ForegroundColor = foregroundColor;

    if (showSedcAtEnd)
    {
        msg = $"{msg} SEDC";
    }
    Console.WriteLine(msg);
}

void WriteInConsoleOtherWay(string msg, // required
    ConsoleColor? backgroundColor = ConsoleColor.Black, // optional
    ConsoleColor? foregroundColor = ConsoleColor.White, // optional
    bool? showSedcAtEnd = false) // optional
{
    if (backgroundColor.HasValue)
    {
        Console.BackgroundColor = backgroundColor.Value;
    }

    if (foregroundColor.HasValue)
    {
        Console.ForegroundColor = foregroundColor.Value;
    }

    if (showSedcAtEnd.HasValue)
    {
        if (showSedcAtEnd.Value)
        {
            msg = $"{msg} SEDC";
        }
    }

    Console.WriteLine(msg);
}


#endregion