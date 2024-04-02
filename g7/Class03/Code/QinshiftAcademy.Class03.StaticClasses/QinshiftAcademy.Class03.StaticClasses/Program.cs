using QinshiftAcademy.Class03.StaticClasses.Domain.Database;
using QinshiftAcademy.Class03.StaticClasses.Domain.Enums;
using QinshiftAcademy.Class03.StaticClasses.Domain.Helpers;
using QinshiftAcademy.Class03.StaticClasses.Domain.Models;

Order order = new Order(1, "two Hamburgers", "One hamburger, one cheeseburger", OrderStatus.Processing);
order.Print();


//we want to access all the users
//we want to print the orders for each of the users

//OrdersDb is a static class and Users is a static property of the same class
foreach(User user in OrdersDb.Users)
{
    user.PrintOrders();
}

//.... a user was added to our db

OrdersDb.Users.Add(new User()
{
    Id = 13,
    Username = "paul",
    Address = "Street 33",
    Orders = new List<Order>()
});

//.....
Console.WriteLine("======Printing the users again========");
foreach (User user in OrdersDb.Users)
{
    user.PrintOrders();
}

//....
Order newOrder = new Order()
{
    Title = "three pizzas",
    Description = "Capri, Margarita, Pepperoni",
    Status = OrderStatus.Processing
};

//OrdersDb.Orders.Add(newOrder);
OrdersDb.AddOrder(newOrder, 12);
Console.WriteLine("======Printing the users again after adding an order========");
foreach (User user in OrdersDb.Users)
{
    user.PrintOrders();
}


string message = "some text";
Console.WriteLine(TextHelper.ToCapitalFirstLetter(message));
