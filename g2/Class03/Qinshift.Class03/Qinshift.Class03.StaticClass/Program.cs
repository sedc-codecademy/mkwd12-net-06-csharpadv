using Qinshift.Class03.Static.Domain;
using Qinshift.Class03.StaticClass;

Console.WriteLine( "Hello world");


//Helper test = new Helper()
User currentUser;
while (true)
{

    #region Main Menu
    Console.Clear();
    Console.WriteLine("Welcome to the ordering menu!");
    Console.WriteLine("Choose a User:");
    OrdersDB.ListUsers();
    int userChoice = Helper.ValidateNumberInput(Console.ReadLine());
    if (userChoice == -1) continue;
    currentUser = OrdersDB.Users[userChoice];
    #endregion
    #region Orders Menu
    Console.WriteLine("Orders menu:");
    Console.WriteLine("1) Check Order");
    Console.WriteLine("2) Add new Order");
    int menuChoice = Helper.ValidateNumberInput(Console.ReadLine());
    if(menuChoice == -1) continue;
    if(menuChoice == 1)
    {
        Console.Clear();
        Console.WriteLine("Print order");
        currentUser.PrintOrder();
        int choiceStatus = Helper.ValidateNumberInput(Console.ReadLine());
        if (choiceStatus == -1) continue;
        Helper.GenerateMessStatus(currentUser.Orders[choiceStatus].Status);
        Console.ReadLine();
    }
    else if(menuChoice == 2)
    {
        Console.Clear();
        Orders newOrder = new Orders();
        Console.Write("Enter order name: ");
        newOrder.Title = Console.ReadLine();
        Console.Write("Enter order description: ");
        newOrder.Descripton = Console.ReadLine();
        OrdersDB.InsertOrder(currentUser.Id, newOrder);
        Console.ReadLine();
    }
    else
    {
        continue;
    }

    #endregion
}