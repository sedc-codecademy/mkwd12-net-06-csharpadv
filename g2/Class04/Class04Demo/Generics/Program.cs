// See https://aka.ms/new-console-template for more information
using Generics.Helpers;

Console.WriteLine("Hello, World!");


#region Generic Methods

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\n\n================ Generic Methods ================\n");
Console.ResetColor();

List<string> strings = new List<string>() { "str1", "str2", "str3" };
List<int> ints = new() { 1, 2, 3, 4, 5 };
List<bool> bools = new() { true, false, true, false };

// ===> NON GENERIC METHODS EXAMPLE
NotGenericListHelper notGenericListHelper = new NotGenericListHelper();

notGenericListHelper.GoThroughStrings(strings);
notGenericListHelper.GetInfoForStrings(strings);

notGenericListHelper.GoThroughIntegers(ints);
notGenericListHelper.GetInfoForIntegers(ints);
// => prodcut, user, double...

// ===> GENERIC METHODS EXAMPLE
GenericListHelper genericListHelper = new GenericListHelper();
genericListHelper.GoThroughList<string>(strings);
//genericListHelper.GoThroughList(strings);
genericListHelper.GetListInfo(strings);

genericListHelper.GoThroughList<bool>(bools);
genericListHelper.GetListInfo(bools);

#endregion


#region Generic Classes
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n\n================ Generic Classes ================\n");
Console.ResetColor();



#endregion
Console.ReadLine();