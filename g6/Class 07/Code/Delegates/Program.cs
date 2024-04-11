

void SayHello(string text)
{
    Console.WriteLine("hello" + text);
}

void Greeting(string name, PrintDelegate print)
{
    print("Ana");
}

//here we decalre the deleagte
//the delegate defines the signature of a given method
//when we see PrintDelegate through the code, we need to expect a method with this signature (void and one string param)
delegate void PrintDelegate(string text);
