using Static.Domain.Models;
using Static.Domain.Enums;
using Static.Domain;
using System.Security;
using Static.Domain.Helpers;

//Order order = new Order(1, "First order", "Our first order", OrderStatusEnum.Created);
//Console.WriteLine(order.Description);

//order.PrintTitle();//we call this method using the order object (instance)

//Order.IsValid(order); //because the method Isvalid is static we need to call (access) this method with the class Order

//Array.Reverse()

Console.WriteLine("Welcome to our ordering app");
Console.WriteLine("Choose the number for your user:");

OrdersDb.PrintUsers();
string input = Console.ReadLine();


//validation
int userChoice = TextHelper.ValidateInput(input);

Console.WriteLine("The last id of the orders is: " + OrdersDb.lastOrderId);

Order lastOrder = OrdersDb.Orders.LastOrDefault();
if(lastOrder != null)
{
    Console.WriteLine("The last id of the orders is: " + lastOrder.Id);
}

if(userChoice == -1)
{
    Console.WriteLine("Invalid input");
}
else
{
    User currentUser = OrdersDb.Users[userChoice - 1];
    Console.WriteLine("Choose an option");
    Console.WriteLine("1. Print your orders");
    Console.WriteLine("2. Add new order");
    string optionInput = Console.ReadLine();
    //validation
    int optionChoice = TextHelper.ValidateInput(optionInput);

    if(optionChoice == -1)
    {
        Console.WriteLine("Invalid option");
    }
    else
    {
        if(optionChoice == 1)
        {
            currentUser.PrintOrders(); //User is a standard class and PrintOrders is a standard method so we use an object to call this method
        }
        else if(optionChoice == 2)
        {
            //1. enter data for the new order
            Console.WriteLine("Enter title:");
            string titleInput = Console.ReadLine();
            Console.WriteLine("Enter description:");
            string descriptionInput = Console.ReadLine();
            //2.validate the data
            if(string.IsNullOrEmpty(titleInput) || string.IsNullOrEmpty(descriptionInput)) {
                throw new Exception("Title and description must not be null");
            }
            //3. create the order instance

            Order newOrder = new Order();
            newOrder.Title = titleInput;
            newOrder.Description = descriptionInput;
            newOrder.Print(); //Print is not a static method so we call it with the object (instance)

            //4. add the order to the database
            OrdersDb.InsertOrder(currentUser.Id, newOrder);
            Console.WriteLine("Successfully added new order");
            currentUser.PrintOrders();
        }
    }
}

