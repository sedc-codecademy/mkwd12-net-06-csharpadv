using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryBeingFit.Domain.Models;

namespace TryBeingFit.Services.Interfaces
{
    public interface IUserService<T> where T : User
    {

       T Register(T newUser);

        T Login(string username, string password);

        List<T> GetAll();

        void RemoveById(int userId);

        T ChangeInfo(int userId, string firstName, string lastName);    

        T ChangePassword(int userId, string oldPassword, string newPassword);
    }
}
