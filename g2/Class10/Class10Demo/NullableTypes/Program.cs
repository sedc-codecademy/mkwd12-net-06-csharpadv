using Helpers;
using NullableTypes;

ExtendedConsole.PrintInColor("\n================= NULLABLE TYPES =================\n\n", ConsoleColor.Cyan);

// ===> VALUE types are NOT NULLABLE by default

// int number = null; // won't work because int is not nullable by default
int? number = null; // with the '?' we can make the non-nullable types to be nullable

//double decimalNumber = null;
double? decimalNumber = null;

//bool isTrue = null;
bool? isTrue = null;

DateTime? dateTime = null;

// NOTE: string is nullable by default
string text = null;
string? text2 = null; // here we explicitly tell that this variable is nullable

// ===> PERSON EXAMPLE
Person person = null;

Person bob = new Person();
Console.WriteLine(bob.Name); // null
Console.WriteLine(bob.Id); // 0
Console.WriteLine(bob.Score); // null
Console.WriteLine(bob.IsEmployed); // false
// bob.IsEmployed = null; // We can't put null in a bool
Console.WriteLine(bob.HasPet); // null
