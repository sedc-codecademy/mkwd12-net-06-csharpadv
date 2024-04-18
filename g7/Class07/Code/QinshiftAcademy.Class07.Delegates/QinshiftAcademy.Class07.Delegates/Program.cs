void SayHello(string name)
{
    Console.WriteLine($"Hello {name}");
}

//the Greeting method expects a method that follows the PrintingDelegate signature as a second parameter
//it needs to get a method that is void and has one string param as second parameter
void Greeting(string name, PrintingDelegate printingDelegate)
{
    printingDelegate(name);
}

Greeting("Marko", SayHello);
Greeting("Ana", x => Console.WriteLine($"Hello {x}"));

int Sum(int num1, int num2)
{
    return num1 + num2;
}

int Subtract(int num1, int num2)
{
    return num1 - num2;
}

void PrintResult(int num1, int num2 , NumbersDelegate numbersDelegate)
{
    int result = numbersDelegate(num1, num2);
    Console.WriteLine($"Result: {result}");
}

//Just as a comparison how it will look like without delegate
void PrintResult2(int num1, int num2, string operation)
{
    if(operation == "+")
    {
        int result = num1 + num2;
        Console.WriteLine($"Result {result}");
    }
    else if(operation == "-")
    {
        int result = num1 - num2;
        Console.WriteLine($"Result {result}");
    }
    else
    {
        Console.WriteLine("Wrong input");
    }
}

PrintResult2(3, 4, "+");
PrintResult2(10, 7, "-");

PrintResult(3, 4, Sum);
PrintResult(10, 7, Subtract);


NumbersDelegate numbersDelegate = new NumbersDelegate(Sum);
numbersDelegate(3, 4);


//Decalre the delegate
//each delegate defines a signature of a given method, can be used to store a method that follows this signature
//for example, when we encounter the PrintingDelegate in code, we will expect a method there that will be void
//and will have just one parameter of type string
delegate void PrintingDelegate(string name);
delegate int NumbersDelegate(int num1, int num2);
