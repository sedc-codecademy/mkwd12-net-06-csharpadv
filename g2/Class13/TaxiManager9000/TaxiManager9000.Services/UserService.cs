using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;
using TaxiManager9000.Helpers;
using TaxiManager9000.Services.Interfaces;

namespace TaxiManager9000.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public User CurrentUser { get; set; }

        public void Login(string username, string password)
        {
            User userDb = GetAll().SingleOrDefault(u => u.Username.Equals(username, StringComparison.InvariantCultureIgnoreCase) && u.Password == password);
            if (userDb is null)
            {
                throw new Exception("Login failed! Invalid credentials entered! Try again...");
            }
            CurrentUser = userDb;
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
           if(CurrentUser.Password != oldPassword || !ValidationHelper.ValidatePassword(newPassword) || oldPassword == newPassword)
            {
                return false;
            }
           CurrentUser.Password = newPassword;
            //bool isUpdate = Update(CurrentUser);
            //return isUpdate;
            return Update(CurrentUser);
        }

        public void CreateNewUser(string username, string password, Role role)
        {
            bool userExists = GetAll().Any(x => x.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            if (userExists)
            {
                throw new Exception("User already exists!");
            }
            User newUser = new User(username, password, role);
            Insert(newUser);
        }

    }
}
