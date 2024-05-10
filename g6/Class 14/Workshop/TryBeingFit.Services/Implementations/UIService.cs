using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Models;
using TryBeingFit.Services.Interfaces;

namespace TryBeingFit.Services.Implementations
{
    public class UIService : IUIService
    {
        public StandardUser FillRegisterData()
        {
            //ask for data

            string firstName = EnterData("first name");
            string lastName = EnterData("last name");
            string username = EnterData("username");
            string password = EnterData("password");
            string confirmedPassword = EnterData("confirm password");

            if(password != confirmedPassword)
            {
                throw new Exception("Passwords do not match");
            }

            //if data is not empty, create the user that will be registered
            StandardUser standardUser = new StandardUser()
            {
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password
            };
            return standardUser;    
        }

        public string EnterData(string field)
        {
            while (true)
            {
                Console.WriteLine($"Please enter {field}");
                string data = Console.ReadLine();
                if (string.IsNullOrEmpty(data))
                {
                    Console.WriteLine($"You must enter {field}");
                    continue;
                }
                else 
                { return data; }
            }
           
        }

        public string MainMenu(UserRoleEnum userRole)
        {
            List<string> menuItems = new List<string>();   
            menuItems.Add("Train");
            switch (userRole)
            {
                case UserRoleEnum.Standard:
                    menuItems.Add("Upgrade to premium");
                    break;
                case UserRoleEnum.Trainer:
                    menuItems.Add("Reschedule a training");
                    break;
            }

            menuItems.Add("Account info");
            menuItems.Add("Logout");
            int numInput = 0;
            while (true)
            {
                Console.WriteLine("Choose an option");
                for(int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuItems[i]}");
                }

                string input = Console.ReadLine();

                bool isNumber = int.TryParse(input, out numInput);
                if (!isNumber)
                {
                    Console.WriteLine("You must enter a number");
                    continue;
                }

                if (numInput < 1 || numInput > menuItems.Count)
                {
                    Console.WriteLine("Invalid option");
                    continue;
                }
                break;

            }
            return menuItems[numInput - 1]; //if we chose 1. Train we want the item with index 0 -> train
        }
        }
    }

