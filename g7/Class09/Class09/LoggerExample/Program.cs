using LoggerExample.Entities;

LoggerService logger = new LoggerService();
List<User> users = new List<User>()
{
    new User(){Username = "Bob20", Password = "123456", Age = 20, Id = 4 },
    new User(){Username = "JillCool", Password = "coolcat", Age = 34, Id = 12 },
    new User(){Username = "Gregonator", Password = "astalavista", Age = 44, Id = 76 }
};
void Login(string username, string password)
{
    User user = users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
    if (user == null) throw new InvalidLoginException(username);
    Console.WriteLine($"Welcome {username}!");
}

try
{
    Console.WriteLine("Welcome to the amazing app!");
    Console.WriteLine("Enter username:");
    string username = Console.ReadLine();
    Console.WriteLine("Enter password:");
    string password = Console.ReadLine();
    Login(username, password);

}
catch (InvalidLoginException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Check your username and password and try again!");
    logger.Log("InvalidLogin", ex.Message, ex.Username);
}
catch (InvalidUserPropertyException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Try and enter a correct value please!");
    logger.Log("InvalidUserProperty", ex.Message, ex.BrokenUser);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Please try again or contact support!");
    logger.Log(ex.GetType().Name, ex.Message);
    logger.LogError();
}
Console.WriteLine("Enjoy your day!");
Console.ReadLine();