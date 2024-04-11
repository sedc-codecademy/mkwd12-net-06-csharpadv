

using QinshiftAcademy.Class06.AdvancedLINQ.Models;

namespace QinshiftAcademy.Class06.AdvancedLINQ
{
    public static class ListHelper 
    {
        public static void Print<T>(this List<T> list) where T : BaseEntity
        {
            Console.WriteLine("Printing..");
            foreach(T item in list)
            {
                item.PrintInfo();
            }
        }
    }
}
