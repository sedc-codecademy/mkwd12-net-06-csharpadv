using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPractices.Practices
{
    //Bad example
    public class Service
    {
        public List<int> numbers = new List<int>();

        public void GetStats()
        {
            Console.WriteLine("Welcome to the app");
            Console.WriteLine("Enter 5 numbers");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("You entered:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("================");
            Console.WriteLine("Stats:");

            int even = numbers.Where(x => x % 2 == 0).Count();
            Console.WriteLine($"There are {even} even numbers");

            int odd = numbers.Count - even;
            Console.WriteLine($"There are {odd} odd numbers");

            int positive = numbers.Where(x => x > 0).Count();
            Console.WriteLine($"There are {positive} positive numbers");

            int negative = numbers.Count - positive;
            Console.WriteLine($"There are {negative} negative numbers");

            int sum = numbers.Sum();
            Console.WriteLine("Sum of number" + sum);
        }
    }


    //Good example
    public class NumberService
    {
        public List<int> RequestNumbers(int number)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter a number");
                result.Add(int.Parse(Console.ReadLine()));

            }
            return result;
        }

        public void PrintStats(List<int> numbers)
        {
            int even = numbers.Where(x => x % 2 == 0).Count();
            Console.WriteLine($"There are {even} even numbers");

            int odd = numbers.Count - even;
            Console.WriteLine($"There are {odd} odd numbers");

            int positive = numbers.Where(x => x > 0).Count();
            Console.WriteLine($"There are {positive} positive numbers");

            int negative = numbers.Count - positive;
            Console.WriteLine($"There are {negative} negative numbers");

            int sum = numbers.Sum();
            Console.WriteLine("Sum of number" + sum);
        }
    }

    public class HelperService
    {
        public void PrintListInOneLine<T>(List<T> values)
        {
            foreach (T item in values)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    public class AppService
    {
        private NumberService _numberService;
        private HelperService _helperService;
        private List<int> _numbers;

        public AppService()
        {
            _numberService = new NumberService();
            _helperService = new HelperService();
            _numbers = new List<int>();
        }

        public void AppInit()
        {
            Console.WriteLine("Welcome to the app");
            Console.WriteLine("Enter 5 numbers");
            _numbers = _numberService.RequestNumbers(5);

            Console.WriteLine("You entered:");
            _helperService.PrintListInOneLine(_numbers);

            Console.WriteLine("Stats:");
            _numberService.PrintStats(_numbers);
        }
    }
}
