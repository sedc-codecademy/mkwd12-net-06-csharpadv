using QinshiftAcademy.TryBeingFit.Domain.Models;

namespace TryBeingFit.Services.Interfaces
{
    public interface IUserService<T> where T : User
    {
        void ChangePassword(int userId, string oldPassword, string newPassword);
        T Login(string username, string password);
        T Register(T userModel);
        T GetById(int id);
        T ChangeInfo(int userId, string firstName, string lastName);
        void RemoveById(int id);
    }
}
