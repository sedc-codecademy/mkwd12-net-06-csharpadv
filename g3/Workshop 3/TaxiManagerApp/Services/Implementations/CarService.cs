using DataAccess;
using Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class CarService : ICarService
    {
        private Storage _storage;

        public CarService()
        {
            _storage = new Storage();
        }

        public void CreateCar(string licensePlate, DateTime licensePlateExpiryDate, string model)
        {
            //if (_storage.Users.GetAll().Any(x => x.Username == username))
            //    throw new Exception($"User with username {username}, already exists");

            //var newUser = new User(0, firstName, lastName, username, password, role);
            //_storage.Users.Add(newUser);

            if(_storage.Cars.GetAll().Any(x => x.LicensePlate.ToLower() == licensePlate.ToLower()))
            {
                throw new Exception($"Car with license plate {licensePlate}, already exists");
            }

            if(licensePlateExpiryDate < DateTime.UtcNow)
            {
                throw new Exception($"The car has expired license plate");
            }

            var newCar = new Car(0, licensePlate, licensePlateExpiryDate, model);

            _storage.Cars.Add(newCar);
        }
    }
}
