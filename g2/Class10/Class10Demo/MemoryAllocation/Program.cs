using Helpers;
using MemoryAllocation;

ExtendedConsole.PrintInColor("\n================= STACK & HEAP =================\n\n", ConsoleColor.DarkCyan);



ExtendedConsole.PrintInColor("\n================= Value types & Reference types =================\n\n", ConsoleColor.Cyan);

ExtendedConsole.PrintInColor("====== Value types ======\n");
int num1 = 10;
int num2 = num1;
num2 = 50;
Console.WriteLine(num1); // 10
Console.WriteLine(num2); // 50

ExtendedConsole.PrintInColor("\n====== Reference types ======\n");

List<int> ints1 = new() { 1, 2, 3 };
List<int> ints2 = ints1;
ints2[1] = 10_000;
Console.WriteLine(ints1[1]); // 10_000
Console.WriteLine(ints2[1]); // 10_000 ???
//ints1.ForEach(i => Console.WriteLine(i));
//ints2.ForEach(i => Console.WriteLine(i));


// ===> Example: User

User john = new User
{
    FirstName = "John",
    LastName = "Doe",
    Age = 30
};

User john2 = john;
john.PrintInfo(); // age 30
john2.PrintInfo(); // age 30

john2.Age = 50;

john.PrintInfo(); // age 50
john2.PrintInfo(); // age 50

ExtendedConsole.PrintInColor("\n====== Strings ======\n");

string stringOne = "String One";
string stringTwo = stringOne;
Console.WriteLine(stringOne);
Console.WriteLine(stringTwo);

stringTwo = "String Two";

Console.WriteLine(stringOne);
Console.WriteLine(stringTwo);

Console.Clear();
ExtendedConsole.PrintInColor("\n================= OBJECTS LIFECYCLE =================\n\n", ConsoleColor.Cyan);

static void TestObjectLifeCycle()
{
    User bob = new User("Bob", "Bobsky", 34);
    User jill = new User(age: 30, lastName: "Bobsky", firstName: "Jill");
    Console.WriteLine("Logic with objets...");
    bob.PrintInfo();
    Console.WriteLine("More logic...");
    jill.PrintInfo();
    Console.WriteLine("Okay, we don't neet the objets anymore. Throw them in the trash...");
}
TestObjectLifeCycle();


Console.ReadLine();