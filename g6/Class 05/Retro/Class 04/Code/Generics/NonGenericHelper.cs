using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class NonGenericHelper
    {
        public void PrintListOfStrings(List<string> strings)
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        public void PrintListOfInts(List<int> ints)
        {
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }

        public void PrintInfoForStringList(List<string> strings)
        {
            //the ? checks if it is null, and only if it is not null it will call the GetType => this way we escape the chance of an error
            Console.WriteLine($"The list has {strings.Count} members. They are of type {strings.FirstOrDefault()?.GetType().Name}"); 
        }
        //int a = 5;
        //int? b = null;
        public void PrintInfoForIntList(List<int> ints)
        {
            //the ? checks if it is null, and only if it is not null it will call the GetType => this way we escape the chance of an error
            Console.WriteLine($"The list has {ints.Count} members. They are of type {ints.FirstOrDefault().GetType().Name}");
        }
    }
}
