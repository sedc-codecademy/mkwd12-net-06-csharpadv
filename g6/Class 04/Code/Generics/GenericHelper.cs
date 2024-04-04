using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   public static class GenericHelper<T>
    {
        public static void PrintList(List<T> items)
        {
            foreach(T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintListInfo(List<T> items)
        {
            Console.WriteLine($"The list has {items.Count} members. They are of type {items.FirstOrDefault()?.GetType().Name}");

        }

        //if we want to use multiple generics we need to specify them after the name of the method in <> brackets
        public static void Test<T1, T2, R>(T1 firstParameter, T2 secondParameter, List<R> listR) 
        { Console.WriteLine($"First: {firstParameter}, Second: {secondParameter}"); }
    }
}
