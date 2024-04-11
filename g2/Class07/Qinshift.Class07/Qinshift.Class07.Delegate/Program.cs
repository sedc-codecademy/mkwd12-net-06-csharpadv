
#region Methods
void SayHello(string name)
{
    Console.WriteLine($"Hello {name}");
}
void SayBye(string name)
{
    Console.WriteLine($"Bye bye {name}");
}
void SayWhatever(string whatever, SayDelegate sayDel)
{
    Console.Write($"Says: ");
    sayDel(whatever);
}
void Number(int num1, int num2, NumberDelegate numberDelegate)
{
    Console.WriteLine($"The result is: {numberDelegate(num1,num2)}");
}
#endregion

SayDelegate del = new SayDelegate(SayHello);
SayDelegate bye = new SayDelegate(SayBye);
SayDelegate wow = new SayDelegate(x => Console.WriteLine($"{x} wow!!!!"));

//Using the delegate
del("Bob");
bye("Jill");
wow("Delegate");

Console.WriteLine("============================");
SayWhatever("Bla bla", SayBye);
SayWhatever("Test test", SayHello);
SayWhatever("Greg", x => Console.WriteLine($"{x} proba."));
Console.WriteLine("============================");

Number(2,3,(x,y)=> x+y);
Number(2,3,(x,y)=> x-y);
Number(2,3,(x,y)=> x*y);
Number(9,3,(x,y)=> x/y);
Number(2,5,(x,y)=>
{
    if (x >= y) return x;
    return y;
});

delegate void SayDelegate(string something);
delegate int NumberDelegate(int num1, int num2);

