using Generics;
using Generics.Domain;
using Generics.Domain.Models;

NonGenericHelper nonGenericHelper = new NonGenericHelper();
List<string> strings = new List<string>() { "Hello", "G6", "Bye" };
List<int> ints = new List<int>() { 1, 55, 78 };

nonGenericHelper.PrintListOfStrings(strings);
nonGenericHelper.PrintListOfInts(ints);
nonGenericHelper.PrintInfoForStringList(strings);
nonGenericHelper.PrintInfoForIntList(ints);

GenericHelper<string>.PrintList(strings);
GenericHelper<int>.PrintList(ints);

GenericHelper<string>.PrintListInfo(strings);
GenericHelper<int>.PrintListInfo(ints);

//T will be replaced with Order for this instance of GenericDb
GenericDb<Order> ordersDb = new GenericDb<Order>();

//T will be replaced with Product for this instance of GenericDb
GenericDb<Product> productsDb = new GenericDb<Product>();
//GenericDb<int> ints = new GenericDb<int>(); ERROR => int does not inherit from BaseEntity


Product product = new Product();
product.Id = 1;
product.Title = "Pizza";
product.Description = "Delicious pizza";
productsDb.Add(product);

productsDb.Add(new Product { Id = 2, Title = "Coca Cola", Description = "Delicious drink" });

productsDb.PrintAll();

productsDb.RemoveById(1);

productsDb.PrintAll();

ordersDb.Add(new Order { Id = 1, OrderedBy = "Petko", Address = "Address no 1" });
ordersDb.PrintAll();