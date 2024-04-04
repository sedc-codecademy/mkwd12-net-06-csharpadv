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

GenericDb<Order> ordersDb = new GenericDb<Order>();

//GenericDb<int> ints = new GenericDb<int>(); ERROR => int does not inherit from BaseEntity