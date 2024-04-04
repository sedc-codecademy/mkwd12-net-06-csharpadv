

namespace QinshiftAcademy.Class04.ExtensionMethods
{
    public static class ListHelper
    {
        //this method is generic, anywhere we have T in the method, we can replace with any type
        public static void PrintAll<T>(this List<T> items)
        {
            foreach(T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
