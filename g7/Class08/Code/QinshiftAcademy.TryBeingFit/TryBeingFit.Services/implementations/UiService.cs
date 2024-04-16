using QinshiftAcademy.TryBeingFit.Domain.Enums;
using QinshiftAcademy.TryBeingFit.Domain.Models;
using TryBeingFit.Services.Helpers;
using TryBeingFit.Services.Interfaces;

namespace TryBeingFit.Services.implementations
{
    public class UiService : IUiService
    {
        public List<string> MenuItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
                    Console.WriteLine($"[{i + 1}] {menuItems[1]}");
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
            throw new NotImplementedException();
        }

        public int LogInMenu()
        {
            throw new NotImplementedException();
        }

        public int MainMenu(UserType userType)
        {
            throw new NotImplementedException();
        }

        public int RoleMenu()
        {
            throw new NotImplementedException();
        }

        public int TrainMenu()
        {
            throw new NotImplementedException();
        }

        public int TrainMenuItems<T>(List<T> trainings) where T : Training
        {
            throw new NotImplementedException();
        }

        public void UpgradetoPremiumInfo()
        {
            throw new NotImplementedException();
        }
    }
}
