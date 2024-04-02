using Qinshift.Class03.Static.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.Class03.Static.Domain
{
    // Static helper class that we can use to help us out with some tasks involving text
    // We can call these methods without creating an instance of the class
    public static class Helper
    {
        // This value will be the same value from everywhere, no matter from where do we change it
        public static int MessageGenerated = 0;
        //public string Test { get; set; } no static methods

        public static int ValidateNumberInput(string input)
        {
            bool isMenuChoiceValid = int.TryParse(input, out int choise);
            if (!isMenuChoiceValid)
            {
                Console.WriteLine("Wrong input!!! Pleas enter valid number");
                return -1;
            }
            return choise;
        }

        public static string CapitalFirstLetter(string word)
        {
            if(word.Length == 0)
            {
                return "Empty string";
            }
            else if(word.Length == 1)
            {
                return char.ToUpper(word[0]).ToString();
            }
            else
            {
                return char.ToUpper(word[0]) + word.Substring(1);
            }
        }

        public static void GenerateMessStatus(OrderStatus orderStaus)
        {
            string rezult = "";
            switch (orderStaus)
            {
                case OrderStatus.Processing:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    rezult = "[Processing] The order is being processed";
                    break;
                case OrderStatus.Delivered:
                    Console.ForegroundColor = ConsoleColor.Green;
                    rezult = "[Deliverd] The order is sucessfully delivered!";
                    break;
                case OrderStatus.CouldNotDeliver:
                    Console.ForegroundColor = ConsoleColor.Red;
                    rezult = "[CouldNotDeliver] There was a problem with the delivery!";
                    break;
                default:
                    rezult = "status was not found";
                    break;
            }
            Console.WriteLine(rezult);
            Console.ResetColor();
            MessageGenerated++;
        }
    }
}
