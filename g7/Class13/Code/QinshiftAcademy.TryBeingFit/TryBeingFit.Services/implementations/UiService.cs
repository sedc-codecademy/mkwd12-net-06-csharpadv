using QinshiftAcademy.TryBeingFit.Domain.Enums;
using QinshiftAcademy.TryBeingFit.Domain.Models;
using TryBeingFit.Services.Helpers;
using TryBeingFit.Services.Interfaces;

namespace TryBeingFit.Services.implementations
{
    public class UiService : IUiService
    {
        public List<string> MenuItems { get; set; }

        public int AccountMenu()
        {
            List<string> accountMenuItems = new List<string>() { "Change info", "Change password"};
            return ChooseMenuItem(accountMenuItems);
        }

        public int ChooseMenuItem(List<string> menuItems)
        {
            while (true)
            {
                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {menuItems[i]}");
                }
                string input = Console.ReadLine();
                int choice = ValidationHelper.ValidateNumber(input, menuItems.Count);
                if (choice == -1)
                {
                    MessageHelper.PrintMessage("You must enter a valid option", ConsoleColor.Red);
                    continue;
                }
                return choice;
            }
        }

        public StandardUser FillNewUserData()
        {
            StandardUser standardUser = new StandardUser();

            Console.WriteLine("enter first name");
            string firstName = Console.ReadLine();
            if (string.IsNullOrEmpty(firstName))
            {
                throw new Exception("You must enter first name");
            }

            Console.WriteLine("enter last name");
            string lastName = Console.ReadLine();
            if (string.IsNullOrEmpty(lastName))
            {
                throw new Exception("You must enter first name");
            }

            Console.WriteLine("enter username");
            string username = Console.ReadLine();
            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("You must enter username");
            }

            Console.WriteLine("enter password");
            string password = Console.ReadLine();
            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("You must enter password");
            }

            standardUser.FirstName = firstName;
            standardUser.LastName = lastName;
            standardUser.Username = username;
            standardUser.Password = password;

            return standardUser;
        }

        public int LogInMenu()
        {
            List<string> menuItems = new List<string> { "LogIn", "Register" };
            Console.WriteLine("Choose option");
            return ChooseMenuItem(menuItems);
        }

        public int MainMenu(UserType userType)
        {
            MenuItems = new List<string>();
            MenuItems.Add("Account");
            MenuItems.Add("Log Out");

            switch (userType)
            {
                case UserType.StandardUser:
                    MenuItems.Add("Train");
                    MenuItems.Add("Upgrade to Premium");
                    break;
                case UserType.PremiumUser:
                    MenuItems.Add("Train");
                    break;
                case UserType.Trainer:
                    MenuItems.Add("Reschedule training");
                    break;
            }
            return ChooseMenuItem(MenuItems);
        }

        public int RoleMenu()
        {
            List<string> menuItems = Enum.GetNames(typeof(UserType)).ToList();
            Console.WriteLine("Choose role");
            return ChooseMenuItem(menuItems);
        }

        public int TrainMenu()
        {
            List<string> trainMenuItems = new List<string>() { "Video", "Llive" };
            return ChooseMenuItem(trainMenuItems);
        }

        public int TrainMenuItems<T>(List<T> trainings) where T : Training
        {
            Console.WriteLine("Choose a training:");
            return ChooseEntity(trainings);
        }

        public void UpgradetoPremiumInfo()
        {
            Console.WriteLine("Upgrade to premium offers:");
            Console.WriteLine("Live Trainings");
            Console.WriteLine("Get discount in sports stores:");
        }

        private int ChooseEntity<T>(List<T> entities) where T: Training
        {
            while (true)
            {
                for (int i = 0; i < entities.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {entities[i].GetInfo()}");
                }
                string input = Console.ReadLine();
                int choice = ValidationHelper.ValidateNumber(input, entities.Count);
                if(choice == -1)
                {
                    MessageHelper.PrintMessage("You must enter a valid option", ConsoleColor.Red);
                    continue;
                }
                return choice;
            }
        }
    }
}
