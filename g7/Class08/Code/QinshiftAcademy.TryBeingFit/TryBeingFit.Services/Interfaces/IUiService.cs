using QinshiftAcademy.TryBeingFit.Domain.Enums;
using QinshiftAcademy.TryBeingFit.Domain.Models;

namespace TryBeingFit.Services.Interfaces
{
    public interface IUiService
    {
        List<string> MenuItems { get; set; }
        int ChooseMenuItem(List<string> menuItems);
        int LogInMenu();
        int RoleMenu();
        int MainMenu(UserType userType);
        int TrainMenu();
        int TrainMenuItems<T>(List<T> trainings) where T : Training;
        void UpgradetoPremiumInfo();
        int AccountMenu();
        StandardUser FillNewUserData();
    }
}
