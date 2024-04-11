# Delegates and Events 🥧

## Delegates 🔹

Values in C# always have a certain type. Just as values can be represented by a type, so can methods. Delegates are types that represent references to methods. If the method and the delegate share the same signature ( Return and parameter types ) then the delegate can be instantiated with a method that meets the requirements. This means that we can use Delegates as types for methods in a code block, but also as a parameter to a method, creating a higher-order method. In a delegate, a method can be passed as an argument and the result stored as well as a lambda expression. These methods can then be passed to any other place of the type of the delegate, even if they have a different implementation.

### Delegates in Action

```csharp
// Declaring a delegate
public delegate void SayDelegate(string something);

public static void SayHello(string person)
{
    Console.WriteLine($"Hello {person}!");
}
public static void SayBye(string person)
{
    Console.WriteLine($"Bye {person}!");
}

SayDelegate del = new SayDelegate(SayHello); // The SayDelegate points to SayHello
SayDelegate bye = new SayDelegate(SayBye); // The SayDelegate points to SayBye
SayDelegate wow = new SayDelegate(x => Console.WriteLine($"Wow {x}!")); // The SayDelegate points to an anonymous method

// Using the delegate ( Points to methods )
del("Bob");
bye("Jill");
wow("Greg");
```

#### Delegates as parameters

```csharp
public delegate int NumbersDelegate(int num1, int num2);

public static void SayWhatever(string whatever, SayDelegate sayDel)
{
  Console.Write("Chatbot says:");
  sayDel(whatever);
}
SayWhatever("Bob", SayHello);
SayWhatever("Jill", SayBye);
SayWhatever("Greg", x => Console.WriteLine($"Wow {x}!"));
SayWhatever("Anne", x =>
{
    Console.WriteLine($"Stuff with {x}");
    Console.WriteLine($"Other stuff with {x}");

public static void NumberMaster(int num1, int num2, NumbersDelegate numberDel)
{
    Console.WriteLine($"The result is: {numberDel(num1, num2)}");
}

NumberMaster(2, 5, (x, y) => x + y);
NumberMaster(2, 5, (x, y) => x - y);
NumberMaster(2, 5, (x, y) => 0);
NumberMaster(2, 5, (x, y) =>
{
    if (x > y) return x;
    return y;
});
});
```


## Extra Materials 📘

* [Microsoft - Delegates](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/)
* [C# In Depth - Delegates and Events](https://csharpindepth.com/articles/Events)
