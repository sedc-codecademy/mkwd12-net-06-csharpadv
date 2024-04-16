using DataAccess;
using Models;
using Services.Implementations;
using Services.Interfaces;

namespace TaxiManagerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUIService uiService = new UIService();

            uiService.Login();

            while (true)
            {
                uiService.ShowMenu();
                var users = Storage.Users.GetAll();
            }
        }
    }
}
