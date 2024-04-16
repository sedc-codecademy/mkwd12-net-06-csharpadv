using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Helpers;
using TaxiManager9000.Services.Enums;
using TaxiManager9000.Services.Interfaces;

namespace TaxiManager9000.Services
{
    public class UIService : IUIService
    {
        public List<MenuChoice> MenuItems { get; set; }

        public User LoginMenu()
        {
            Console.Clear();
            ExtendedConsole.PrintInColor("\nEnter your credentials:", ConsoleColor.Cyan);
            string username = ExtendedConsole.GetInput("Username: ");
            string password = ExtendedConsole.GetInput("Password: ");
            if (!ValidationHelper.ValidateStringInput(username) || !ValidationHelper.ValidateStringInput(password))
            {
                throw new Exception("Please enter valid inputs!");
            }
            return new User()
            {
                Username = username,
                Password = password
            };
        }

        public int MainMenu(Role role)
        {
            throw new NotImplementedException();
        }

        public int ChooseMenu<T>(List<T> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {items[i]}");
            }
            int choice = ValidationHelper.ValidateNumberInput(Console.ReadLine(), items.Count);
            return choice;
        }

        public int ChooseEntitiesMenu<T>(List<T> entities) where T : BaseEntity
        {
            throw new NotImplementedException();
        }

        public void EndMenu()
        {
            throw new NotImplementedException();
        }

    }
}
