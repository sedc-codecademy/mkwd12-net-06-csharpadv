using LoggerExample;

LoggerService loggerService = new LoggerService();

List<User> users = new List<User>
{
    new User { Id =1, FirstName = "Petko", LastName = "Petkovski", Username = "ppetkovski", Password = "Test123"},
    new User { Id =2, FirstName = "Stefan", LastName = "Stefanovski", Username ="sstefanovski", Password="P@ssw0rd"}
};

void Login (string username, string password)
{
    User user = users.FirstOrDefault(x => x.Username == username && x.Password == password);    
    if(user == null)
    {
        throw new Exception($"Invalid login for {username}");
    }
}

try
{
    Console.WriteLine("Enter username");
    string username = Console.ReadLine();

    Console.WriteLine("Enter password");
    string password = Console.ReadLine();

    loggerService.Log($"Trying to log in a user with username {username}", false);
    Login(username, password);

}catch(Exception ex)
{
    //the console writeline is what is shown to the user, so that he knows that an error occured
    Console.WriteLine("An error occured");
    Console.WriteLine(ex.Message);

    loggerService.Log(ex.Message, true); //here we send the message and we send true -> it was an error (we are in the catch block)
}