void SayHello(string name)
{
    Console.WriteLine($"Hello {name}");
}

PrintDelegate printDelegate = new PrintDelegate(SayHello);
printDelegate("G6"); //SayHello("G6")

//we can also pass anonymous methods
PrintDelegate secondPrintDelegate = new PrintDelegate(x => Console.WriteLine("Goodbye " + x));
secondPrintDelegate("Petko");


//follow NumberDelegate signature
int Sum(int n1, int n2)
{
    return n1 + n2;
}

NumbersDelegate numbersDelegate = new NumbersDelegate(Sum);
numbersDelegate(2, 3); //Sum(2,3)

//PASSING METHOD AS ARGUMENT TO SOME OTHER METHOD

void Greeting (string name, PrintDelegate printDelegate)
{
    printDelegate(name);
}

//in this call of Greeting method we pass SayHello method as second argument
//SayHello comes as value for printDelegate param in Greeting method
//it can be called through printDelegateParam and we can give it a string param(name)
Greeting("Ana", SayHello);
Greeting("Bob", x => Console.WriteLine("Goodbye " + x));

//Declare delegates
//the delagate defines the signature of a given method
//when we see PrintDelegate we need to expect a method eith this signature -> void and one string param
delegate void PrintDelegate(string text);
delegate int NumbersDelegate(int num1, int num2);