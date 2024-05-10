using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.Services.Interfaces
{
    public interface IUserService : IServiceBase<User>
    {
        User CurrentUser { get; set; }
        void Login(string username, string password);
        bool ChangePassword(string oldPassword, string newPassword);
        void CreateNewUser(string username, string password, Role role);
    }
}
