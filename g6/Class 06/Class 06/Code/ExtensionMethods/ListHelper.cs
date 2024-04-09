using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ListHelper
    {
        public static string Getinfo<T>(this List<T> items)
        {
            return $"This list has {items.Count} members {items.First().GetType().Name}";
        }
    }
}
