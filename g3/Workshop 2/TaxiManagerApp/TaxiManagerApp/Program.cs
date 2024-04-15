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

            var loggedInUser = CurrentSession.CurrentUser;


        }
    }
}
