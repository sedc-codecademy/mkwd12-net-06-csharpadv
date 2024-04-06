using DataAccess;
using Models;

namespace TaxiManagerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage.Users.Add(new User(0, "Risto", "Panchevski", "risto", "asdasdasd", Models.Enums.RoleEnum.Admin));

            var users = Storage.Users.GetAll();
            var cars = Storage.Cars.GetAll();
        }
    }
}
