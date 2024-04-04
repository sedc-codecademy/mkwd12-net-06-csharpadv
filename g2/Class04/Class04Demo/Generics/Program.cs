// See https://aka.ms/new-console-template for more information
using Generics.Domain;
using Generics.Domain.Models;
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
//genericListHelper.GetListInfo(strings);
GenericListHelper.GetListInfo(strings);

genericListHelper.GoThroughList<bool>(bools);
//genericListHelper.GetListInfo(bools);
GenericListHelper.GetListInfo(bools);

#endregion


#region Generic Classes
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n\n================ Generic Classes ================\n");
Console.ResetColor();

GenericDb<Order> OrderDb = new GenericDb<Order>();
GenericDb<Product> ProductDb = new GenericDb<Product>();

// Inserting into database
OrderDb.Insert(new Order(1, "Bob", "Bob Street"));
OrderDb.Insert(new Order(2, "Jill", "Jill Street"));
OrderDb.Insert(new Order(3, "Greg", "Greg Street"));

ProductDb.Insert(new Product(10, "Mouse", "For gaming"));
ProductDb.Insert(new Product(20, "Headphones", "For gaming"));
ProductDb.Insert(new Product(30, "USB", "64 GB"));

// Printing the items
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n==========================\n");
Console.WriteLine("Orders:");
OrderDb.PrintAll();
Console.WriteLine("\n==========================\n");
Console.WriteLine("Products:");
ProductDb.PrintAll();
Console.WriteLine("\n==========================\n");
Console.ResetColor();


#endregion

#region Using generics within a certain scope
//GenericDb<Dog> DogsDb = new GenericDb<Dog>();

#endregion
Console.ReadLine();