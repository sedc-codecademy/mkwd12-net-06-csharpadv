using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QinshiftAcademy.Class04.Generics
{
    public class NonGenericHelper
    {
        public void PrintList(List<int> ints)
        {
            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }
        }

        public void PrintList(List<string> strings)
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        public void PrintValue(int i)
        {
            Console.WriteLine($"The value is {i}");
        }

        public void PrintValue(string s)
        {
            Console.WriteLine($"The value is {s}");
        }

        public void PrintListInfo(List<int> ints)
        {
            Console.WriteLine($"The list has {ints.Count} members, of type {ints.First().GetType().Name}");
        }

        public void PrintListInfo(List<bool> bools)
        {
            Console.WriteLine($"The list has {bools.Count} members, of type {bools.First().GetType().Name}");
        }
    }
}
