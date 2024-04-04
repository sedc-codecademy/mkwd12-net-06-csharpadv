// See https://aka.ms/new-console-template for more information
using Generics.Domain;
using Generics.Domain.Models;
using Generics.Helpers;

/*
	*GENERICS* => concept of writing code that can work with multiple types while maintaining type safety.
	
	=> Generics allow you to write classes, methods, and interfaces that can work with any data type. This promotes code reusability, as the same generic type or method can be used with different data types without needing to rewrite the code.
	
	=> Example: List<T> => T is a placeholder for any type of data
	
	=> Types of generic entities:
		1) Generic methods
		2) Generic classes
		3) Generic interfaces 

	=> Usecases:
		1) Generic Repository (Data Access) classes 
		2) Generic Service classes
		3) Generic Helper methods/classes
 */


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
// => NOTE: we need new methods for bool, product, user, long, double ..... BAD !


// ===> GENERIC METHODS EXAMPLE
GenericListHelper genericListHelper = new GenericListHelper();
genericListHelper.GoThroughList<string>(strings);
//genericListHelper.GoThroughList(strings);
//genericListHelper.GetListInfo(strings);
GenericListHelper.GetListInfo(strings); // works as well with static methods

genericListHelper.GoThroughList<bool>(bools);
//genericListHelper.GetListInfo(bools);
GenericListHelper.GetListInfo(bools);

// => NOTE: no need for new methods for different types
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


// Examples of using the other methods
Console.WriteLine("\n================ Get By Id From Order and Product Db ================\n");
Order order = OrderDb.GetById(1);
Product product = ProductDb.GetById(10);
Product product100 = ProductDb.GetById(100);
Console.WriteLine(order.GetInfo());
Console.WriteLine(product.GetInfo());

Console.WriteLine("\n================ Get by Index From Order and Product Db ================\n");
Order order1 = OrderDb.GetByIndex(2);
// Product product1 = ProductDb.GetByIndex(20); // ArgumentOutOfRangeException
Product product1 = ProductDb.GetByIndex(0);
Console.WriteLine(order1.GetInfo());
Console.WriteLine(product1.GetInfo());

Console.WriteLine("\n================ Remove item From Order and Product Db ================\n");
OrderDb.RemoveById(3);
ProductDb.RemoveById(30);


Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("\n==============================\n");
Console.WriteLine("Orders:");
OrderDb.PrintAll();
Console.WriteLine("\n==============================\n");
Console.WriteLine("Products:");
ProductDb.PrintAll();
Console.WriteLine("\n==============================\n");
Console.ResetColor();
#endregion


#region Using generics within a certain scope
// only classes derived from BaseEntity are allowed to use GenericDb<T>
// this is possible because we've added "where T : BaseEntity"

//GenericDb<Dog> DogsDb = new GenericDb<Dog>(); // ERROR !!!

#endregion


Console.ReadLine();