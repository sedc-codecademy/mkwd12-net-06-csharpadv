using DataAccess;
using Services.Interfaces;
using Models.Enums;
using Models;

namespace Services.Implementations
{
    public class DriverCarService : IDriverCarService
    {
        private Storage _storage;

        public DriverCarService()
        {
            _storage = new Storage();
        }

        public void AssignDriverToCar(int driverId, int carId, int shift)
        {
            var user = _storage.Users.GetById(driverId);
            var driver = (Driver)user;

            if (driver.Role != RoleEnum.Driver)
                throw new Exception("Selected user is not a driver");

            if(driver.LicenseExpiryDate < DateTime.UtcNow)
                throw new Exception("Driver license has expired");

            var cars = _storage.Cars.GetAll();

            if(cars.Any(x => x.Drivers.Any(y => y.Value.Id == driverId)))
            {
                throw new Exception("Driver is already assigned to car");
            }

            var car = cars.FirstOrDefault(x => x.Id == carId);

            if(car == null)
            {
                throw new Exception($"Car with id: {carId} does not exist");
            }

            if(car.Drivers.Any(x => x.Key == (ShiftEnum) shift))
            {
                throw new Exception($"The car has already assigned driver for {(ShiftEnum)shift} shift");
            }

            car.Drivers.Add((ShiftEnum)shift, driver);
            _storage.Cars.Update(car);
        }
    }
}
