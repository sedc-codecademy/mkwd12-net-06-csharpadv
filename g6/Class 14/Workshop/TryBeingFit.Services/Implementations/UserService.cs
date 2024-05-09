using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryBeingFit.Domain.Database;
using TryBeingFit.Domain.Models;
using TryBeingFit.Services.Helpers;
using TryBeingFit.Services.Interfaces;

namespace TryBeingFit.Services.Implementations
{
    public class UserService<T> : IUserService<T> where T : User
    {
        //always make the classes dependent on interface (dependent only on the signature)
        //this way we will be able to provide different implementations that implement the same methods (with the same signature)
        private IDatabase<T> _database;

        public UserService()
        {
            //we can always assign an object from a class that impelents an interface to a variable
            //with type interface (new Database() -> IDatabase)
            //here we tell that we will use the implementation from the Database.cs, but only the methods that are present in the interface
            _database = new Database<T>();

            //if eventually we want to change the implementation and use the implemention of another class
            //the only place that we need to change is here
            //we are sure that this ExampleDatabase has all the methods that were used by Database.cs because they both follow the rules
            //from the IDatabase interface
            //_database = new ExampleDatabase<T>();
        }
        public List<T> GetAll()
        {
            List<T> items = _database.GetAll();
            return items;
        }

        public T Login(string username, string password)
        {
           //1. search through all user for a user with the given username and password

            //1.1.get all users
            List<T> allUsers = _database.GetAll();
            //1.2. search
            T user = allUsers.FirstOrDefault(x => x.Username ==  username  && x.Password == password);

            if(user == null)
            {
                throw new Exception("Wrong username or password");
            }

            //2. return the user
            return user;
        }

        public T Register(T newUser)
        {
            //1.validation - rules and already exists
          
            if(newUser == null)
            {
                throw new Exception("User cannot be null");
            }

            List<T> items = GetAll();
            //  List<T> items = _database.GetAll();
            //items.FirstOrDefault(x => x.Username == newUser.Username);
            bool alreadyExists = items.Any(x => x.Username.ToLower() == newUser.Username.ToLower());
            if (alreadyExists)
            {
                throw new Exception("User already exists");
            }

            if (!ValidationHelper.ValidateName(newUser.FirstName))
            {
                throw new Exception("Invalid first name value");
            }

            if (!ValidationHelper.ValidateName(newUser.LastName))
            {
                throw new Exception("Invalid last name value");
            }

            if (!ValidationHelper.ValidateUsername(newUser.Username))
            {
                throw new Exception("Invalid username value");
            }

            if (!ValidationHelper.ValidatePassword(newUser.Password))
            {
                throw new Exception("Invalid password value");
            }

            //2. insert into the db (list items)
             int id = _database.Insert(newUser);

            //3. find and return the newly added user from the db
            T user = _database.GetById(id);
            return user;
        }

        public void RemoveById(int userId)
        {
            //validation
            //it is a good practise to first check id there is a record with that id in the db
            //the app might receive multiple requests at the same time and someone might have already deleted the item
            T user  = _database.GetById(userId);
            if(user == null)
            {
                throw new Exception($"User with id {userId} was not found in the db");
            }

            _database.RemoveById(userId);
        }
    }
}
