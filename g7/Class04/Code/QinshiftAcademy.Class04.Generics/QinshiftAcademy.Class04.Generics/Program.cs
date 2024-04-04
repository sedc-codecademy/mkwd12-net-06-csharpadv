using QinshiftAcademy.Class04.Generics;
using QinshiftAcademy.Class04.Generics.Models;

NonGenericHelper nonGenericListHelper = new NonGenericHelper();

List<string> strings = new List<string> { "Hello", "Hi", "Welcome" };
List<int> ints = new List<int> { 4, 7, 89, 79 };
List<bool> bools = new List<bool> { true, false, false};

nonGenericListHelper.PrintListInfo(ints);
nonGenericListHelper.PrintListInfo(bools);

nonGenericListHelper.PrintValue(5);
nonGenericListHelper.PrintValue("C#");


GenericHelper<string> genericHelper = new GenericHelper<string>();
genericHelper.PrintValue("Hello");
genericHelper.PrintList(strings);

GenericHelper<int> intGenericHelper = new GenericHelper<int>();
intGenericHelper.PrintValue(5);
intGenericHelper.PrintList(ints);

//in this object, T will be replaced by Product
GenericDb<Product> productsGenericDb = new GenericDb<Product>();
productsGenericDb.Add(new Product()
{
    Id = 1,
    Title = "Pizza",
    Description = "Capri"
});
productsGenericDb.Add(new Product()
{
    Id = 2,
    Title = "Burger",
    Description = "Cheeseburger"
});
productsGenericDb.PrintAllItems();

//in this object, T will be replaced by Order
GenericDb<Order> ordersGenericDb = new GenericDb<Order>();
ordersGenericDb.Add(new Order()
{
    Id = 1,
    Address = "Address 1",
    OrderedBy = "marko"
});
ordersGenericDb.PrintAllItems();


List<Product> products = productsGenericDb.GetAll();

List<Order> orders = ordersGenericDb.GetAll();

Product product = productsGenericDb.GetById(1);
if(product == null)
{
    Console.WriteLine("We didn't find a product with id 1");
}

Order order = ordersGenericDb.GetById(5);
if (order == null)
{
    Console.WriteLine("We didn't find a order with id 5");
}


productsGenericDb.RemoveById(1);
productsGenericDb.PrintAllItems();