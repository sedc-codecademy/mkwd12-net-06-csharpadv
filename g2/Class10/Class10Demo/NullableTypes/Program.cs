using Helpers;
using NullableTypes;

ExtendedConsole.PrintInColor("\n================= NULLABLE TYPES =================\n\n", ConsoleColor.Cyan);

//int number = null;
int? number = null;

//double decimalNumber = null;
double? decimalNumber = null;

//bool isTrue = null;
bool? isTrue = null;

DateTime? dateTime = null;


string text = null;
string? text2 = null;


Person person = null;

Person bob = new Person();
Console.WriteLine(bob.Name); // null
Console.WriteLine(bob.Id); // 0
Console.WriteLine(bob.Score); // null
Console.WriteLine(bob.IsEmployed); // false
Console.WriteLine(bob.HasPet); // null
