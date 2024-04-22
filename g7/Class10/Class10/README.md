
```

## Nullable values 🔹

In C# all values must have a type, which is something that we already established. The types can be value and reference types. Value types are usually primitive types such as integer or boolean. Reference types point to some complex entity such as an object. When objects are empty they hold the value of null, meaning that there is nothing there. That is the default value of any object. But value types hold a default value from their context, meaning that their default value resembles a normal value that can be interpreted as an intentional one. For instance, an integer has a default value of 0. This means that if we have a scoring system and somehow, a student gets an error and their score is not updated, the default value will stay 0 and that could be interpreted that the student had an error OR that the student didn't score any points. Because of this, in C# there is an option to make any value that does not accept null as a value to nullable. Nullable means that the type will accept values from its context as well as null. This can make logic much more precise and developers can implement code with fewer assumptions and special cases. Nullable is noted as a question mark after the type.

> Note: Among the primitive values, a string is nullable by design, and the? a notation will not work on it

```csharp
public class Person
{
    public int Id { get; set; }
    public int? Score { get; set; }
    public string Name { get; set; }
}

// Since we didn't add any value to this person, all values will be nullable
Person prs = new Person();
Console.WriteLine(prs.Id); // Is 0 by default
Console.WriteLine(prs.Score); // Empty result in the console
Console.WriteLine(prs.Score == null); // Is null by default
Console.WriteLine(prs.Name); // Empty result in the console
Console.WriteLine(prs.Name == null); // Is null by default

// prs.Id = null; // Throws an error. We can't put null in an int
prs.Score = null; // If it's nullable we can add null as a value
```

## Extra Materials 📘

* [Stack and Heap in .NET in depth](https://www.c-sharpcorner.com/article/C-Sharp-heaping-vs-stacking-in-net-part-i/)
* [All About IDisposable](https://gunnarpeipman.com/csharp-idisposable/)
* [Microsoft - Cleaning unmanaged resources](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/unmanaged)
* [Implementing Disposable Classes in depth](https://www.codeproject.com/Articles/15360/Implementing-IDisposable-and-the-Dispose-Pattern-P)
* [Microsoft - Named and Optional arguments](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments)
