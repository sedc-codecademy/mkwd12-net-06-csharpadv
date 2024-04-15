using Services.Interfaces;

namespace Services.Implementations
{
    public class UIService : IUIService
    {
        private IUserService _userService;

        public UIService()
        {
            _userService = new UserService();   
        }

        public void Login()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please login!");
                    Console.Write("Username: ");
                    var username = Console.ReadLine();

                    Console.Write("Password: ");
                    var password = Console.ReadLine();

                    _userService.Login(username, password);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please try again!");
                }
            }
        }

        public void LogOut()
        {
            Console.WriteLine("Thank you for using our app");
            _userService.LogOut();
        }
    }
}
