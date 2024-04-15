using Models.Enums;

namespace Services.Interfaces
{
    public interface IUserService
    {
        void Login(string username, string password);
        void LogOut();
        void CreateUser(string firstName, string lastName, string username, string password, RoleEnum role);
        void CreateUser(string firstName, string lastName, string username, string password, string licenseNumber, DateTime licenseExpiryDate);
        void TerminateUser(int userId);
    }
}
