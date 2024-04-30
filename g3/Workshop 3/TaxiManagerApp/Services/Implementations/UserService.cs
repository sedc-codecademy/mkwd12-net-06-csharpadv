using DataAccess;
using Models;
using Models.Enums;
using Services.Interfaces;
using System.Data;

namespace Services.Implementations
{
    public class UserService : IUserService
    {
        private Storage _storage;

        public UserService()
        {
            _storage = new Storage();
        }

        public void Login(string username, string password)
        {
            var loginUser = _storage.Users.GetAll().FirstOrDefault(x => x.Username == username);

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
        public void CreateUser(string firstName, string lastName, string username, string password, RoleEnum role)
        {
            if (_storage.Users.GetAll().Any(x => x.Username == username))
                throw new Exception($"User with username {username}, already exists");

            var newUser = new User(0, firstName, lastName, username, password, role);
            _storage.Users.Add(newUser);
        }

        public void CreateUser(string firstName, string lastName, string username, string password, string licenseNumber, DateTime licenseExpiryDate)
        {
            if (_storage.Users.GetAll().Any(x => x.Username == username))
                throw new Exception($"User with username {username}, already exists");

            var newUser = new Driver(0, firstName, lastName, username, password, licenseNumber, licenseExpiryDate);
            _storage.Users.Add(newUser);
        }

        public void TerminateUser(int userId)
        {
            var user = _storage.Users.GetById(userId);

            if(user.Id == CurrentSession.CurrentUser.Id)
            {
                throw new Exception("You cannot delete yourself!");
            }

            var carsDrivenByTheUser = _storage.Cars.GetAll().Where(x => x.Drivers.Any(y => y.Value.Id == user.Id));

            foreach(var car in carsDrivenByTheUser)
            {
                var shiftDriverPair = car.Drivers.FirstOrDefault(x => x.Value.Id == user.Id);
                car.Drivers.Remove(shiftDriverPair.Key);

                _storage.Cars.Update(car);
            }

            _storage.Users.Delete(user);
        }
    }
}
