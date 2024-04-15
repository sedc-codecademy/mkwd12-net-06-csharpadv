using DataAccess;
using Models;
using Services.Interfaces;

namespace Services.Implementations
{
    public class UserService : IUserService
    {
        public void Login(string username, string password)
        {
            var loginUser = Storage.Users.GetAll().FirstOrDefault(x => x.Username == username);

            if (loginUser == null)
                throw new Exception("Non existing user!");

            if(!loginUser.CheckPassword(password))
            {
                throw new Exception("Wrong password!");
            }

            CurrentSession.CurrentUser = loginUser;
        }

        public void LogOut()
        {
            CurrentSession.CurrentUser = null;
        }
    }
}
