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
            while (true)
            {
                Console.Clear();
                ExtendedConsole.PrintTitle($"\n\t*** {role.ToString().ToUpper()} MENU ***\n\n");
                MenuItems = GetMenuOptionsForRole(role);
                int userChoice = ChooseMenu(MenuItems);
                if (userChoice == -1)
                {
                    ExtendedConsole.PrintError("Invalid choice! Try again...");
                    continue;
                }
                return userChoice;
            }
        }

        /// <summary>
        /// Displays a menu of items from a list and prompts the user to choose an item by entering a number corresponding to the item.
        /// </summary>
        /// <typeparam name="T">The type of items in the list.</typeparam>
        /// <param name="items">A list of items to be displayed in the menu.</param>
        /// <returns>An integer representing the index of the chosen item in the list or -1 if invalid choice was made.</returns>
        public int ChooseMenu<T>(List<T> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {items[i]}");
            }
            int choice = ValidationHelper.ValidateNumberInput(Console.ReadLine(), items.Count);
            return choice;
        }

        /// <summary>
        /// Displays a menu of entities that inherit from the BaseEntity class and prompts the user to choose an entity by entering a number corresponding to the entity.
        /// </summary>
        /// <typeparam name="T">The type of entities in the list.</typeparam>
        /// <param name="entities">A list of entities to be displayed in the menu.</param>
        /// <returns>An integer representing the index of the chosen entity in the list or -1 if invalid choice was made.</returns>
        public int ChooseEntitiesMenu<T>(List<T> entities) where T : BaseEntity
        {
            Console.Clear();
            if (entities.Count == 0)
            {
                ExtendedConsole.NoItemsMessage<T>();
                Console.ReadLine();
                return -1;
            }
            while (true)
            {
                Console.WriteLine("Enter a number to choose one of the following:");
                for (int i = 0; i < entities.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {entities[i].GetInfo()}");
                }
                int choice = ValidationHelper.ValidateNumberInput(Console.ReadLine(), entities.Count);
                if (choice == -1)
                {
                    ExtendedConsole.PrintError("Invalid choice! Try again...");
                    Console.Clear();
                    continue;
                }
                return choice;
            }
        }

        public void EndMenu()
        {
            Console.Clear();
            ExtendedConsole.PrintTitle("\n\n\n\n\n\n\n              *** THANK YOU FOR USING OUR APP ***");
            Console.ReadLine();
        }

        /// <summary>
        ///  Retrieves the menu options available for a specific role.
        /// </summary>
        /// <param name="role">The role for which to retrieve the menu options.</param>
        /// <returns>A list of menu choices available for the specified role.</returns>
        private List<MenuChoice> GetMenuOptionsForRole(Role role)
        {
            switch (role)
            {
                case Role.Administrator:
                    return new List<MenuChoice>()
                        {
                            MenuChoice.AddNewUser,
                            MenuChoice.RemoveExistingUser,
                            MenuChoice.ChangePassword,
                            MenuChoice.Exit
                        };
                case Role.Manager:
                    return new List<MenuChoice>()
                        {
                            MenuChoice.ListAllDrivers,
                            MenuChoice.TaxiLicenseStatus,
                            MenuChoice.DriverManager,
                            MenuChoice.ChangePassword,
                            MenuChoice.Exit
                        };
                case Role.Maintenance:
                    return new List<MenuChoice>()
                        {
                            MenuChoice.ListAllCars,
                            MenuChoice.LicensePlateStatus,
                            MenuChoice.ChangePassword,
                            MenuChoice.Exit
                        };
                default: 
                    return new List<MenuChoice>();
            }
        }

    }
}
