using Helpers;
using MemoryAllocation;


#region Value & Reference types

ExtendedConsole.PrintInColor("\n================= STACK & HEAP =================\n\n", ConsoleColor.DarkCyan);

// STACK
// => used for static memory allocation
// => stores value types and reference to the reference type

// HEAP
// => used for dynamic memory allocation
// => stores the actual data of the reference types
// => is managed by the garbage collector, which automatically frees up memory that is no longer being used


ExtendedConsole.PrintInColor("\n================= Value types & Reference types =================\n\n", ConsoleColor.Cyan);
// VALUE TYPES => both *reference* (variable) and *value* are stored on the STACK
// bool, byte, char, int, decimal, double, enum, float, long, short, struct...

// REFERENCE TYPES => *reference* is stored on the STACK, the actual *value* on the HEAP
// classes (objects), interface, delegate, *string*...

// *STRINGS* => special type, are considered reference type


ExtendedConsole.PrintInColor("====== Value types ======\n");
int num1 = 10;
int num2 = num1; // it assignes only the value to the new variable num2
num2 = 50; // the change won't affect num1 
Console.WriteLine(num1); // 10
Console.WriteLine(num2); // 50


ExtendedConsole.PrintInColor("\n====== Reference types ======\n");

List<int> ints1 = new() { 1, 2, 3 };
List<int> ints2 = ints1; // passing reference to the ints1 list
ints2[1] = 10_000; // will affect the original ints1 list
Console.WriteLine(ints1[1]); // 10_000
Console.WriteLine(ints2[1]); // 10_000 
//ints1.ForEach(i => Console.WriteLine(i));
//ints2.ForEach(i => Console.WriteLine(i));

// ===> Example: User
User john = new User
{
    FirstName = "John",
    LastName = "Doe",
    Age = 30
};

User john2 = john; // passing reference to the john object
john.PrintInfo(); // age 30
john2.PrintInfo(); // age 30

john2.Age = 50; // will affect john object as well

john.PrintInfo(); // age 50
john2.PrintInfo(); // age 50

ExtendedConsole.PrintInColor("\n====== Strings ======\n");
// ***NOTE*** Even though strings are REFERENCE type and the values are stored on the heap, they behave like VALUE types in many ways

string stringOne = "String One";
string stringTwo = stringOne;
Console.WriteLine(stringOne);
Console.WriteLine(stringTwo);

stringTwo = "String Two";

Console.WriteLine(stringOne); // String One
Console.WriteLine(stringTwo); // String Two
#endregion


#region Objects Lifecycle

ExtendedConsole.PrintInColor("\n================= OBJECTS LIFECYCLE =================\n\n", ConsoleColor.Cyan);

static void TestObjectLifeCycle()
{
    User bob = new User("Bob", "Bobsky", 34);
    // ===> when using *named parameters* the order doesn't matter
    User jill = new User(age: 30, lastName: "Bobsky", firstName: "Jill");
    Console.WriteLine("Logic with objets...");
    bob.PrintInfo();
    Console.WriteLine("More logic...");
    jill.PrintInfo();
    Console.WriteLine("Okay, we don't neet the objets anymore. Throw them in the trash...");
}

TestObjectLifeCycle();
#endregion


Console.ReadLine();