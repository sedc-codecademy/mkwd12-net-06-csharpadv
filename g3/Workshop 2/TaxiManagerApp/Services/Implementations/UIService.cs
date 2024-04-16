using DataAccess;
using Models;
using Models.Enums;
using Services.Interfaces;
using System.Data;

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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Successful Login! Welcome {CurrentSession.CurrentUser.FirstName} user [{CurrentSession.CurrentUser.Role}]");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please try again!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        public void LogOut()
        {
            Console.WriteLine("Thank you for using our app");
            _userService.LogOut();
        }

        public void ShowMenu()
        {
            if (CurrentSession.CurrentUser == null)
            {
                Login();
                return;
            }

            Console.WriteLine("Please select option from the menu: ");
            switch (CurrentSession.CurrentUser.Role)
            {
                case RoleEnum.Admin:
                    ShowAdminMenu();
                    break;
            }
        }

        private void ShowAdminMenu()
        {
            Console.WriteLine("1. Create new user");
            Console.WriteLine("2. Terminate user");
            Console.WriteLine("3. Logout");
            int option = ChooseAnOption(1, 3);

            switch (option)
            {
                case 1:
                    CreateNewUser();
                    break;
                case 2:
                    TerminateUser();
                    break;
            }
        }


        private void CreateNewUser()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please add info for the new user: ");
                    Console.Write("First name: ");
                    var firstName = Console.ReadLine();
                    Console.Write("Last name: ");
                    var lastName = Console.ReadLine();
                    Console.Write("Username: ");
                    var userName = Console.ReadLine();
                    Console.Write("Password: ");
                    var password = Console.ReadLine();
                    Console.WriteLine("Select role (1. Admin; 2. Maintenance; 3. Manager; 4. Driver): ");
                    var roleNumber = ChooseAnOption((int)RoleEnum.Admin, (int)RoleEnum.Driver);

                    if (roleNumber == (int)RoleEnum.Driver)
                    {
                        Console.Write("License number: ");
                        var licenseNumber = Console.ReadLine();
                        Console.Write("License expiry date: ");
                        var licenseExpiryDate = InsertDate();
                        _userService.CreateUser(firstName, lastName, userName, password, licenseNumber, licenseExpiryDate);
                    }
                    else
                    {
                        _userService.CreateUser(firstName, lastName, userName, password, (RoleEnum)roleNumber);
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Successfully created user with username {userName}!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please try again!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private void TerminateUser()
        {
            var users = Storage.Users.GetAll();

            users.ForEach(x => Console.WriteLine($"{x.Id}. {x.FirstName} {x.LastName} [{x.Role}]"));

            var minId = users.Select(x => x.Id).Min();
            var maxId = users.Select(x => x.Id).Max();


            while (true)
            {
                var selectedUserId = ChooseAnOption(minId, maxId);

                try
                {
                    _userService.TerminateUser(selectedUserId);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Successfully terminated user with id {selectedUserId}!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                } catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
        }

        private DateTime InsertDate()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (!DateTime.TryParse(input, out DateTime date))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input, try again");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                if (date > DateTime.Now)
                {
                    return date;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The date time is in past!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }
        }

        private int ChooseAnOption(int min, int max)
        {
            while (true)
            {
                Console.Write("Please choose an option: ");
                var input = Console.ReadLine();

                if (!int.TryParse(input, out int number))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input, try again");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                if (number >= min && number <= max)
                {
                    return number;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong input, range: {min} - {max}, try again");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }
        }
    }
}

