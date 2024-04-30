using DataAccess;
using Models;
using Models.Enums;
using Services.Interfaces;
using System.Data;

namespace Services.Implementations
{
    public class UIService : IUIService
    {
        private IUserService _userService;
        private ICarService _carService;
        private IDriverCarService _driverCarService;
        private Storage _storage;

        public UIService()
        {
            _userService = new UserService();
            _storage = new Storage();
            _carService = new CarService();
            _driverCarService = new DriverCarService();
        }

        public void Login()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please login!");
                    Console.Write("Username: ");
                    var username = Console.ReadLine();

                    Console.Write("Password: ");
                    var password = Console.ReadLine();

                    _userService.Login(username, password);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Successful Login! Welcome {CurrentSession.CurrentUser.FirstName} user [{CurrentSession.CurrentUser.Role}]");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please try again!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        public void LogOut()
        {
            Console.WriteLine("Thank you for using our app");
            _userService.LogOut();
        }

        public void ShowMenu()
        {
            if (CurrentSession.CurrentUser == null)
            {
                Login();
                return;
            }

            Console.WriteLine("Please select option from the menu: ");
            switch (CurrentSession.CurrentUser.Role)
            {
                case RoleEnum.Admin:
                    ShowAdminMenu();
                    break;
                case RoleEnum.Manager:
                    ShowManagerMenu();
                    break;
            }
        }

        private void ShowAdminMenu()
        {
            Console.WriteLine("1. Create new user");
            Console.WriteLine("2. Terminate user");
            Console.WriteLine("3. Logout");
            int option = ChooseAnOption(1, 3);

            switch (option)
            {
                case 1:
                    CreateNewUser();
                    break;
                case 2:
                    TerminateUser();
                    break;
                case 3:
                    _userService.LogOut();
                    break;
            }
        }

        private void ShowManagerMenu()
        {
            Console.WriteLine("1. Create new car");
            Console.WriteLine("2. Assign driver to car");
            Console.WriteLine("3. Logout");
            int option = ChooseAnOption(1, 3);

            switch (option)
            {
                case 1:
                    CreateNewCar();
                    break;
                case 2:
                    AssignDriver();
                    break;
                case 3:
                    _userService.LogOut();
                    break;
            }
        }

        private void CreateNewUser()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please add info for the new user: ");
                    Console.Write("First name: ");
                    var firstName = Console.ReadLine();
                    Console.Write("Last name: ");
                    var lastName = Console.ReadLine();
                    Console.Write("Username: ");
                    var userName = Console.ReadLine();
                    Console.Write("Password: ");
                    var password = Console.ReadLine();
                    Console.WriteLine("Select role (1. Admin; 2. Maintenance; 3. Manager; 4. Driver): ");
                    var roleNumber = ChooseAnOption((int)RoleEnum.Admin, (int)RoleEnum.Driver);

                    if (roleNumber == (int)RoleEnum.Driver)
                    {
                        Console.Write("License number: ");
                        var licenseNumber = Console.ReadLine();
                        Console.Write("License expiry date: ");
                        var licenseExpiryDate = InsertDate();
                        _userService.CreateUser(firstName, lastName, userName, password, licenseNumber, licenseExpiryDate);
                    }
                    else
                    {
                        _userService.CreateUser(firstName, lastName, userName, password, (RoleEnum)roleNumber);
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Successfully created user with username {userName}!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please try again!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private void TerminateUser()
        {
            var users = _storage.Users.GetAll();

            users.ForEach(x => Console.WriteLine($"{x.Id}. {x.FirstName} {x.LastName} [{x.Role}]"));

            var minId = users.Select(x => x.Id).Min();
            var maxId = users.Select(x => x.Id).Max();


            while (true)
            {
                var selectedUserId = ChooseAnOption(minId, maxId);

                try
                {
                    _userService.TerminateUser(selectedUserId);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Successfully terminated user with id {selectedUserId}!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                } catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
        }

        private void CreateNewCar()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please add info for the new car: ");
                    Console.Write("License plate: ");
                    var licensePlate = Console.ReadLine();
                    Console.Write("License plate expiry date: ");
                    var licensePlateExpiryDate = InsertDate();
                    Console.Write("Car model: ");
                    var carModel = Console.ReadLine();

                    _carService.CreateCar(licensePlate, licensePlateExpiryDate,
                        carModel);

                    WriteLineInColor($"Successfully created car {carModel}!", ConsoleColor.Green);

                    break;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please try again!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private void AssignDriver()
        {
            while (true)
            {
                Console.WriteLine("Please select driver:");
                ListAllDrivers();

                var drivers = _storage.Users.GetAll().Where(x => x.Role == RoleEnum.Driver);
                var selectedDriverId = ChooseAnOption(drivers.Select(x => x.Id).Min(), drivers.Select(x => x.Id).Max());

                Console.WriteLine("Please select car:");
                ListAllCars();

                var cars = _storage.Cars.GetAll();
                var selectedCarId = ChooseAnOption(cars.Select(x => x.Id).Min(), cars.Select(x => x.Id).Max());

                Console.WriteLine("Please select shift:");
                ListAllShifts();
                var selectedShift = ChooseAnOption((int)ShiftEnum.First, (int)ShiftEnum.Third);

                try
                {
                    _driverCarService.AssignDriverToCar(selectedDriverId, selectedCarId, selectedShift);
                    WriteLineInColor($"You have assigned driver {selectedDriverId}, to car {selectedCarId}, for shift {selectedShift}, successfully", ConsoleColor.Green);
                    break;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please try again!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private void ListAllDrivers()
        {
            var drivers = _storage.Users.GetAll().Where(x => x.Role == RoleEnum.Driver);

            foreach(var driver in drivers)
            {
                Console.WriteLine($"{driver.Id}. {driver.FirstName} {driver.LastName}");
            }
        }

        private void ListAllCars()
        {
            var cars = _storage.Cars.GetAll();

            foreach(var car in cars)
            {
                Console.WriteLine($"{car.Id}. {car.Model} [{car.LicensePlate}]");
            }
        }

        private void ListAllShifts()
        {
            Console.WriteLine($"{(int)ShiftEnum.First}. {ShiftEnum.First}");
            Console.WriteLine($"{(int)ShiftEnum.Second}. {ShiftEnum.Second}");
            Console.WriteLine($"{(int)ShiftEnum.Third}. {ShiftEnum.Third}");
        }

        private DateTime InsertDate()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (!DateTime.TryParse(input, out DateTime date))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input, try again");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                if (date > DateTime.Now)
                {
                    return date;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The date time is in past!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }
        }

        private int ChooseAnOption(int min, int max)
        {
            while (true)
            {
                Console.Write("Please choose an option: ");
                var input = Console.ReadLine();

                if (!int.TryParse(input, out int number))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input, try again");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                if (number >= min && number <= max)
                {
                    return number;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong input, range: {min} - {max}, try again");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }
        }

        private void WriteLineInColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

